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
        //LoadProductAsync sends a request of the wanted product information depending on the productID.
        //It returns an instance of ProductModel if successful
        public static async Task<ProductModel> LoadProductAsync(int productID = -1)
        {
            string url = "";
            if (productID > 0)
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
                    ProductModel product = await response.Content.ReadAsAsync<ProductModel>();

                    return product;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        //TODO set-methods (for example price)
    }
}
