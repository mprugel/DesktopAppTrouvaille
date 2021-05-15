using APIconnector;
using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.Models;
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
    }
}
