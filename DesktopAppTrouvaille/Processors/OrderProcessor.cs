using APIconnector;
using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;

namespace DesktopAppTrouvaille.Processors
{
    public class OrderProcessor
    {
        public async Task<List<Order>> LoadOrders(int from, int to)
        {
            string url = "Orders/";
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

     public async Task<bool> PostOrder(OrderPOSTDTO orderPOSTDTO)
        {
            string url = "Orders/";
            HttpResponseMessage response;

            string json = JsonConvert.SerializeObject(orderPOSTDTO);
            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                response = await APIconnection.ApiClient.PostAsync(url, data);
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
