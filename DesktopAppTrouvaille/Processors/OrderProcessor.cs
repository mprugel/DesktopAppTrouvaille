using APIconnector;
using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Processors
{
    public class OrderProcessor
    {
        public async Task<List<Order>> LoadOrders(int from, int to)
        {
            string url = "Orders";
            HttpResponseMessage response;
            try
            {
                response = await APIconnection.ApiClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    List<Order> products = await response.Content.ReadAsAsync<List<Order>>();
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
    }
}
