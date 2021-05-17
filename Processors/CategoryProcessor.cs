using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APIconnector.Processors
{
    class CategoryProcessor
    {
        //LoadCategoryAsync sends a request of the wanted order information depending on the categoryID.
        //It returns an instance of CategoryModel if successful
        public static async Task<CategoryModel> LoadCategoryAsync(int categoryID = -1)
        {
            string url = "";
            if (categoryID > 0)
            {
                url = $"https://localhost:44372/api/Category/{ categoryID }/";
            }
            else
            {
                url = "https://localhost:44372/api/Category/";
            }

            using (HttpResponseMessage response = await APIconnection.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    CategoryModel category = await response.Content.ReadAsAsync<CategoryModel>();

                    return category;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
