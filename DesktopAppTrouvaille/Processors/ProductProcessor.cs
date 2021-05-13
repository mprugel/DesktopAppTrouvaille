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
        public Product LoadProduct(string productID = "3fa85f64-5717-4562-b3fc-2c963f66afa6")
        {
            Console.WriteLine("Call API: ");
            string url = "";
            
                url = "Products/a97d0975-2c03-418a-b780-065cf775ddb0";
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
