using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DesktopAppTrouvaille;
using DesktopAppTrouvaille.Enums;
using DesktopAppTrouvaille.Models;
using Newtonsoft.Json;

namespace APIconnector
{
    public static class APIconnection
    {
        public static string _token = "";

        public static void SetToken(string token)
        {
            _token = token;
            // Set the Token as Default Request Header:
            ApiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
        }

        // Map Enums and strings for accessind the API:
        public static Dictionary<ProductSortCriteria, string> ProductSortDic = new Dictionary<ProductSortCriteria, string>();

        public static Dictionary<SortingOrder, string> SortingOrderDic = new Dictionary<SortingOrder, string>();

        public static Dictionary<OrderSortCriteria, string> OrderSortDic = new Dictionary<OrderSortCriteria, string>();

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

            string url = "https://trouvaille.conveyor.cloud/api/";

            // Read Url from Setting Json:
            try
            {
                string fileText = System.IO.File.ReadAllText(@".\ServerSetting.json");
                ServerSettings settings = JsonConvert.DeserializeObject<ServerSettings>(fileText);
                if (settings != null)
                {
                    url = settings.Url;
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Can't openerverSetting.json!");
            }
           


            ApiClient.BaseAddress = new Uri(url);  //Base-Uri
          
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            InitDictionaries();
        }



        // Inits the Dictionaries:
        public static void InitDictionaries()
        {
            ProductSortDic.Add(ProductSortCriteria.InStock, "InStock");
            ProductSortDic.Add(ProductSortCriteria.Name, "Name");
            ProductSortDic.Add(ProductSortCriteria.Price, "Price");

            SortingOrderDic.Add(SortingOrder.Ascending, "true");
            SortingOrderDic.Add(SortingOrder.Descending, "false");

            OrderSortDic.Add(OrderSortCriteria.Date,"date");
        }
    }
}
