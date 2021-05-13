using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APIconnector.Processors
{
    class ProductProcessor
    {
        public async Task<Product> LoadProduct(int productID = -1)
        {
            string url = "";
            if (productID > -1)
            {
                url = $"https://localhost:44372/api/Product/{ productID }/";
            }
            else
            {
                url = "https://localhost:44372/api/Product/";
            }

            using (HttpResponseMessage response = await APIconnection.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    Product product = await response.Content.ReadAsAsync<Product>();

                    return product;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
