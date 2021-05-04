using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DesktopAppTrouvaille.Models;
using Newtonsoft.Json;

namespace APIconnector
{
    public class APIconnection
    {
        private static APIconnection _connection;
        public static APIconnection Connection 
        { 
            get
            { 
                if(_connection == null)
                {
                    _connection = new APIconnection();
                }
                return _connection;
            }
        }
        private HttpClient _client;

        private APIconnection() 
        {
            // Create and config the Connection:
            _client = new HttpClient();
            _client.BaseAddress = new Uri("http://localhost:5000");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Product>> GetAllProducts()
        {
            List<Product> products = null;
            //DUMMY Values:
            HttpResponseMessage res = await _client.GetAsync("products/");
            if(res.IsSuccessStatusCode)
            {
                string json = await res.Content.ReadAsStringAsync();
                products = JsonConvert.DeserializeObject<List<Product>>(json);
            }

            return products;
        }
    }
}
