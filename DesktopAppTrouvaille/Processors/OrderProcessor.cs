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
    public class OrderProcessor : IOrderProcessor
    {
        public async Task<bool> DeleteOrder(Guid guid)
        {
            string url = "Orders/" + guid;
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


        public async Task<int> GetCount()
        {
            string url = "Orders/Count";
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

        public async Task<List<Order>> LoadOrders(int from, int to)
        {
            string url = "Orders/" + from.ToString() + "/" + to.ToString();
            HttpResponseMessage response;
            try
            {
                response = await APIconnection.ApiClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    List<Order> orders = await response.Content.ReadAsAsync<List<Order>>();
                    return orders;
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

        public async Task<List<Order>> SearchOrders(int from, int to, Guid customerID, DateTime timeFrom, DateTime timeTo, Globals.Globals.OrderState state)
        {
            return new List<Order>();
        }

        public async Task<bool> UpdateOrder(Guid guid, Globals.Globals.OrderState state)
        {
            return true;
        }
    }
     
}
