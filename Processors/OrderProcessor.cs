using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APIconnector.Processors
{
    class OrderProcessor
    {
        //LoadOrderAsync sends a request of the wanted order information depending on the orderID.
        //It returns an instance of OrderModel if successful
        public static async Task<OrderModel> LoadOrderAsync(int orderID = -1)
        {
            string url = "";
            if (orderID > 0)
            {
                url = $"https://localhost:44372/api/Order/{ orderID }/";
            }
            else
            {
                url = "https://localhost:44372/api/Order/";
            }

            using (HttpResponseMessage response = await APIconnection.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    OrderModel order = await response.Content.ReadAsAsync<OrderModel>();

                    return order;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
