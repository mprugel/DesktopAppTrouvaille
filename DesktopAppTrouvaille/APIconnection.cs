using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DesktopAppTrouvaille.Models;

namespace APIconnector
{
    public static class APIconnection
    {
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
            
            ApiClient.BaseAddress = new Uri("https://141.79.34.188:5001/api/");  //Base-Uri
          
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



        }
    }
}
