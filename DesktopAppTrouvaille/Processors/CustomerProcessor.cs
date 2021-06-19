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
    public class CustomerProcessor : ICustomerProcessor
    {
        public Task<bool> DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public async Task<int> GetCount()
        {
            string url = "Customers/Count";
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

        public async Task<List<Customer>> GetCustomers(int from, int to)
        {
            string url = "Customers/";
            HttpResponseMessage response;
            try
            {
                response = await APIconnection.ApiClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    List<Customer> customers = await response.Content.ReadAsAsync<List<Customer>>();
                    return customers;
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

        public Task<List<Customer>> SearchCustomers(int from, int to, Guid customerId, string customerEmail)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCustomer()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
