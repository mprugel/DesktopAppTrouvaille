using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Enums;
using DesktopAppTrouvaille.Exceptions;
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
            catch (Exception)
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
                    throw new GETException();
                }
            }
            catch(Exception)
            {
                throw new GETException();  
            }
           
        }

        public async Task<bool> SaveNewProduct(ProductPOSTDTO product)
        {
            string url = "Products/";
            HttpResponseMessage response;
            try
            {
                string json = JsonConvert.SerializeObject(product);
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
            catch (Exception)
            {
                throw new GETException();
            }

        }

        public async Task<List<Product>> SearchAndFilter(int from, int to, string searchWord, SortingOrder order,ProductSortCriteria sort, ProductFilterCriteria criteria)
        {
            Console.WriteLine("Search...");
            // TODO Create URL-String from criteria:
            string url = string.Format("Products/SearchQuery/{0}/{1}?searchWord={2}&asc={3}&orderBy={4}&onlyActive=false&getCategories=true", from, to, searchWord, APIconnection.SortingOrderDic[order], APIconnection.ProductSortDic[sort]);
            Console.WriteLine(url);
            HttpResponseMessage response;
            try
            {
                List<Guid> guids = new List<Guid>();
                if(criteria != null)
                {
                    guids = criteria.CategroryIDs;
                }
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
                    return new List<Product>();
                }
            }
            catch (Exception)
            {
                throw new GETException();
            }

        }

        public async Task<bool> UpdateProduct(Guid guid, PutProductModel product)
        {
            string url = "Products/" + guid.ToString();
            HttpResponseMessage response;
            try
            {
                string json = JsonConvert.SerializeObject(product);
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
            catch (Exception)
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
            catch (Exception)
            {
                throw new GETException();
            }

        }

        public async Task<List<Product>> LoadProducts(int from, int to)
        {
            string url = "Products/" + from.ToString() + "/" + to.ToString() + "?onlyActive=false";
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
                    return new List<Product>();
                }
            }
            catch (Exception)
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
            catch (Exception)
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
            catch (Exception)
            {
                throw new GETException();
            }
        }

        public async Task<List<Product>> GetProductsByID(List<Guid> guids)
        {
            string url = "Products/GetMultiple";
            HttpResponseMessage response;
            try
            {
                string json = JsonConvert.SerializeObject(guids);
                Console.WriteLine(json);
                StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

                response = await APIconnection.ApiClient.PostAsync(url, data);
                Console.WriteLine(response);
                if (response.IsSuccessStatusCode)
                {
                    List<Product> products = await response.Content.ReadAsAsync<List<Product>>();
                    return products;
                }
                else
                {
                    return new List<Product>();
                }
            }
            catch (Exception)
            {
                throw new GETException();
            }
        }

        public async Task<Manufacturer> GetManufacturerByID(Guid guid)
        {
            string url = "Manufacturer/" + guid.ToString();
            HttpResponseMessage response;
            try
            {
                response = await APIconnection.ApiClient.GetAsync(url);
                Console.WriteLine(response);

                if (response.IsSuccessStatusCode)
                {
                    Manufacturer man = await response.Content.ReadAsAsync<Manufacturer>();
                    return man;
                }
                else
                {
                    return new Manufacturer();
                }
            }
            catch (Exception)
            {
                throw new GETException();
            }
        }
    }
}
