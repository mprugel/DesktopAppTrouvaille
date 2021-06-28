using APIconnector;
using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.FilterCriterias;
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
    public class CustomerProcessor : Processor, ICustomerProcessor
    {
        
        public async Task<bool> DeleteCustomer(Customer customer)
        {
            string url = "Auth/Customer/" + customer.Id;
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
            catch (Exception)
            {
                throw new GETException();
            }
        }

        public async Task<int> GetCount()
        {
            string url = "Auth/Customer/Count";
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
            catch (Exception)
            {
                throw new GETException();
            }
        }

        public async Task<List<Customer>> GetCustomers(int from, int to)
        {
            string url = "Auth/Customer/" + from + "/" + to + "?onlyActive=false";
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
                    return new List<Customer>();
                }
            }
            catch (Exception)
            {
                throw new GETException();
            }
        }

     
        public async Task<List<Customer>> SearchCustomer(int from, int to, CustomerFilter filter)
        {
            string guid = "";
            string onlyActive = "false";
            if(filter.SearchGuid)
            {
                guid = filter.CustomerGuid.ToString();
            }
            if(filter.OnlyActive)
            {
                onlyActive = "true";
            }
           
            string url = string.Format( "Auth/Customer/SearchQuery/{0}/{1}/?customerId={2}&customerEmail={3}&onlyActive={4}",from.ToString(),to.ToString(),guid, filter.Email, onlyActive);
            Console.WriteLine(url);
            HttpResponseMessage response;
            try
            {
                response = await APIconnection.ApiClient.GetAsync(url);
                Console.WriteLine(response.StatusCode);
                if (response.IsSuccessStatusCode)
                {
                    List<Customer> customer = await response.Content.ReadAsAsync<List<Customer>>();

                    return customer;
                }
                else
                {
                    return new List<Customer>();
                }
            }
            catch (Exception)
            {
                throw new GETException();
            }
        }

        public async Task<bool> UpdateCustomer(PutCustomerModel customer, Guid guid)
        {
            string url = "Auth/Customer/?customerId=" + guid.ToString();
            HttpResponseMessage response;
            try
            {
                string json = JsonConvert.SerializeObject(customer);
                StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

                response = await APIconnection.ApiClient.PutAsync(url, data);
                Console.WriteLine(response);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.Conflict)
                {
                    Console.WriteLine(await response.Content.ReadAsStringAsync());
                    ErrorViewModel errorViewModel = new ErrorViewModel();
                    List<string> errors = new List<string>();
                    errorViewModel.Errors = errors;

                    errors.Add("Email already taken");
                    _error = errorViewModel;
                    return false;
                }
                return false;
            }
            catch (Exception)
            {
                throw new GETException();
            }
        } 
    }
}
