using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DesktopAppTrouvaille.Enums;
using DesktopAppTrouvaille.Models;

namespace APIconnector
{
    public static class APIconnection
    {
        // Map Enums and strings for accessind the API:
        public static Dictionary<ProductSortCriteria, string> ProductSortDic = new Dictionary<ProductSortCriteria, string>();

        public static Dictionary<SortingOrder, string> SortingOrderDic = new Dictionary<SortingOrder, string>();

        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            var handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return true;
                };

            ApiClient = new HttpClient(handler);
            
            ApiClient.BaseAddress = new Uri("https://141.79.32.68:5001/api/");  //Base-Uri
          
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            InitDictionaries();
        }

        // Inits the Dictionaries:
        public static void InitDictionaries()
        {
            ProductSortDic.Add(ProductSortCriteria.InStock, "inStock");
            ProductSortDic.Add(ProductSortCriteria.Name, "name");

            SortingOrderDic.Add(SortingOrder.Ascending, "true");
            SortingOrderDic.Add(SortingOrder.Descending, "false");
        }
    }
}
