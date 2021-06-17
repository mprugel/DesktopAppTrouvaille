﻿using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.FilterCriterias;
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

        public async Task<int> GetProductCount()
        {
            string url = "Products/Count";
            HttpResponseMessage response;
            try
            {
                response = await APIconnection.ApiClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    int count = await response.Content.ReadAsAsync<int>();

                    return count;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                throw new GETException();
            }

        }
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

        public async Task<bool> SaveNewProduct(Product product)
        {
            string url = "Products/";
            HttpResponseMessage response;
            try
            {
                ProductPOSTDTO dto = product.toPOSTDTO();
                string json = JsonConvert.SerializeObject(dto);
                StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

                response = await APIconnection.ApiClient.PostAsync(url,data);
                Console.WriteLine(response);
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

        public async Task<List<Product>> SearchAndFilter(string searchWord, ProductFilterCriteria criteria)
        {
            Console.WriteLine("Search...");
            // TODO Create URL-String from criteria:
            string url = "Products/SearchQuery/0/5?searchWord=" + searchWord + "&asc=true&orderBy=gdgsfa";
            Console.WriteLine(url);
            HttpResponseMessage response;
            try
            {
                List<Guid> guids = new List<Guid>();
                guids.Add(new Guid("006217FA-0DA7-409F-AAC3-13766FC81944"));
                string json = JsonConvert.SerializeObject(guids);

                StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

                response = await APIconnection.ApiClient.PostAsync(url, data);
                Console.WriteLine("Response Status: " + response.StatusCode);

                if (response.IsSuccessStatusCode)
                {
                    
                    List<Product> products = await response.Content.ReadAsAsync<List<Product>>();
                    
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


        public async Task<bool> UpdateProduct(Product product)
        {
            string url = "Products/" + product.ProductId;
            HttpResponseMessage response;
            try
            {
                ProductPOSTDTO dto = product.toPOSTDTO();
                string json = JsonConvert.SerializeObject(dto);
                StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

                response = await APIconnection.ApiClient.PutAsync(url, data);
                Console.WriteLine(response);
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

        public async Task<bool> DeleteProduct(Product p)
        {
            string url = "Products/" + p.ProductId;
            HttpResponseMessage response;
            try
            {
                response = await APIconnection.ApiClient.DeleteAsync(url);
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
                    return products;
                }
                else
                {
                    throw new GETException();
                }
            }
            catch (Exception e)
            {
                throw new GETException();
            }
        }

        public async Task<bool> AddCategories(Guid id, List<Guid> categoryGuids)
        {
            string url = "Products/" + id + "/addCategory";
            HttpResponseMessage response;
            try
            {
                string json = JsonConvert.SerializeObject(categoryGuids);
                Console.WriteLine(json);
                StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

                response = await APIconnection.ApiClient.PostAsync(url, data);
                Console.WriteLine(url);
                Console.WriteLine(response);
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

        // Remove List of Categories from a Product:
        public async Task<bool> RemoveCategories(Guid id, List<Guid> categoryGuids)
        {
            string url = "Products/" + id + "/deleteCategory";
            HttpResponseMessage response;
            try
            {
                string json = JsonConvert.SerializeObject(categoryGuids);
                Console.WriteLine(json);
                StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

                response = await APIconnection.ApiClient.PostAsync(url, data);
                Console.WriteLine(response);
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
    }
}
