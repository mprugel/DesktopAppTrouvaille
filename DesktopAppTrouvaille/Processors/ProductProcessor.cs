using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APIconnector.Processors
{
    public class ProductProcessor
    {
        public Product LoadProduct(Guid productID)
        {
            string url = "Products/" + productID.ToString();
            HttpResponseMessage response;
            try
            {
                response = APIconnection.ApiClient.GetAsync(url).Result;
                Console.WriteLine("STATUS: " + response);

                if (response.IsSuccessStatusCode)
                {
                    Product product = response.Content.ReadAsAsync<Product>().Result;

                    return product;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.InnerException);
            }
            return null;  
        }
    }
}
