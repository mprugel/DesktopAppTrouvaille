using APIconnector;
using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Processors
{
    class CategoryProcessor
    {
        public async Task<Category> LoadCategoryByID(Guid id)
        {
            string url = "Categories/" + id.ToString();
            HttpResponseMessage response;
            try
            {
                response = await APIconnection.ApiClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    Category cat = await response.Content.ReadAsAsync<Category>();
                    return cat;
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

        public async Task<List<Category>> LoadCategories()
        {
            string url = "Categories/";
            HttpResponseMessage response;
            try
            {
                response = await APIconnection.ApiClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    List<Category> cat = await response.Content.ReadAsAsync<List<Category>>();
                    return cat;
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

        public async Task<bool> PostCategory(CategoryPOSTDTO categoryPOSTDTO)
        {
            string url = "Categories/";
            HttpResponseMessage response;

            string json = JsonConvert.SerializeObject(categoryPOSTDTO);
            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
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
    }
}
