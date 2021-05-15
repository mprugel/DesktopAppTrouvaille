using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Processors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APIconnector.Processors
{
    public class ProductProcessor
    {
        private CategoryProcessor categoryProcessor = new CategoryProcessor();
        public async Task<Product> LoadProduct(Guid productID)
        {
            string url = "Products/" + productID.ToString();
            HttpResponseMessage response;
            try
            {
                response = await APIconnection.ApiClient.GetAsync(url);
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
            catch(Exception e)
            {
                throw new GETException();  
            }
           
        }

        public async Task<bool> SaveProduct(Product product)
        {
            string url = "Products/" + product.PictureId;
            HttpResponseMessage response;
            try
            {
                ProductPOSTDTO dto = product.toPOSTDTO();
                string json = JsonConvert.SerializeObject(dto);
                StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

                response = await APIconnection.ApiClient.PostAsync(url,data);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new GETException();
            }

        }

        public async Task<List<Product>> LoadProducts(int from, int to)
        {
            string url = "Products/" + from.ToString() + "/" + to.ToString();
            HttpResponseMessage response;
            try
            {
                response = await APIconnection.ApiClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    List<Product> products = await response.Content.ReadAsAsync<List<Product>>();

                    //Load the Categories for each Product:
                    foreach(Product p in products)
                    {
                        foreach(Guid catID in p.ProductCategories)
                        {
                            p.Categories.Add(categoryProcessor.LoadCategoryByID(catID).Result);
                        }
                    }
                    return products;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                throw new GETException();
            }

        }
    }
}
