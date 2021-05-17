using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APIconnector.Processors
{
    class CustomerProcessor
    {
        //

        //LoadCustomerAsync sends a request of the wanted order information depending on the customerID.
        //It returns an instance of CustomerModel if successful
        public static async Task<CustomerModel> LoadCustomerAsync(int customerID = -1)
        {
            string url = "";
            if (customerID > 0)
            {
                url = $"https://localhost:44372/api/ApplicationUser/{ customerID }/";
            }
            else
            {
                url = "https://localhost:44372/api/ApplicationUser/";
            }

            using (HttpResponseMessage response = await APIconnection.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    CustomerModel customer = await response.Content.ReadAsAsync<CustomerModel>();

                    return customer;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
