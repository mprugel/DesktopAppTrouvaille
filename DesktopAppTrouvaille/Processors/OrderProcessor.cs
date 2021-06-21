using APIconnector;
using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using static DesktopAppTrouvaille.Globals.Globals;
using DesktopAppTrouvaille.FilterCriterias;
using DesktopAppTrouvaille.Enums;

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

        public async Task<List<Order>> GetOrdersFRomCustomer(int from, int to, Guid guid)
        {
            string url = string.Format("Orders/{0}/{1}?customerId={2}&fromDateTime=&toDateTime=&orderState=&orderBy=&asc=",
                from, to, guid.ToString());
            Console.WriteLine(url);
            HttpResponseMessage response;
            try
            {
                StringContent data = new StringContent("{}", Encoding.UTF8, "application/json");

                response = await APIconnection.ApiClient.PostAsync(url, data);
                Console.WriteLine("Response Status: " + response.StatusCode);

                if (response.IsSuccessStatusCode)
                {
                    List<Order> orders = await response.Content.ReadAsAsync<List<Order>>();
                    return orders;
                }
                else
                {
                    return new List<Order>();
                }
            }
            catch (Exception e)
            {
                throw new GETException();
            }
        }
        
        public async Task<List<Order>> SearchOrders(int from, int to, OrderCriteria criteria, OrderSortCriteria sortCriteria, SortingOrder order)
        {
            string timeFrom = "";
            string timeto = "";
            string cID = "";
            string orderState = "";

            if (criteria != null)
            {
                timeFrom = criteria.OrderDateFrom.ToString("dd-MM-yyyy");
                timeto = criteria.OrderDateTo.ToString("dd-MM-yyyy");
                orderState = ((int)criteria.OrderState).ToString();
                if(criteria.CustomerGuid != null)
                {
                    cID = criteria.CustomerGuid.ToString();
                }
            }
 
            Console.WriteLine("Search Orders...");
            string url = string.Format("Orders/{0}/{1}?customerId={2}&fromDateTime={3}&toDateTime={4}&orderState={5}&orderBy={6}&asc={7}", 
                from, to, cID, timeFrom, timeto, orderState, APIconnection.OrderSortDic[sortCriteria], APIconnection.SortingOrderDic[order]);
            Console.WriteLine(url);
            HttpResponseMessage response;
            try
            {
                StringContent data = new StringContent("{}", Encoding.UTF8, "application/json");

                response = await APIconnection.ApiClient.PostAsync(url, data);
                Console.WriteLine("Response Status: " + response.StatusCode);

                if (response.IsSuccessStatusCode)
                {
                    List<Order> orders = await response.Content.ReadAsAsync<List<Order>>();
                    return orders;
                }
                else
                {
                    return new List<Order>();
                }
            }
            catch (Exception e)
            {
                throw new GETException();
            }
        }

        public async Task<bool> UpdateOrder(Guid guid, Globals.Globals.OrderState state)
        {
            string url = string.Format( "Orders/{0}?orderState={1}" , guid.ToString(),((int)state).ToString());
            HttpResponseMessage response;

            StringContent data = new StringContent("{}", Encoding.UTF8, "application/json");
            try
            {
                response = await APIconnection.ApiClient.PutAsync(url, data);
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
