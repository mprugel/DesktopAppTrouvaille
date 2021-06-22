using APIconnector;
using DesktopAppTrouvaille.Exceptions;
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
    public class EmployeeProcessor
    {
        public async Task<bool> RegisterNewEmployee(RegisterEmployeeModel employee)
        {
            string url = "Employee/Register";
            HttpResponseMessage response;

            string json = JsonConvert.SerializeObject(employee);
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

        public async Task<bool> LoginEmployee(LoginEmployeeModel employee)
        {
            string url = "Employee/Login";
            HttpResponseMessage response;

            string json = JsonConvert.SerializeObject(employee);
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

        // TODO add GUID:
        public async Task<bool> UpdateEmployee(Guid guid,Employee employee)
        {
            string url = "Employee?employeeId=" + guid.ToString();
            HttpResponseMessage response;

            string json = JsonConvert.SerializeObject(employee);
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

        public async Task<List<Employee>> GetEmployees(int from , int to)
        {
            string url = string.Format("Employee/{0}/{1}", from, to);
            HttpResponseMessage response;

            try
            {
                response = await APIconnection.ApiClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<List<Employee>>();
                }
                else
                {
                    return new List<Employee>();
                }
            }
            catch (Exception e)
            {
                throw new GETException();
            }
        }

        public async Task<int> GetCount()
        {
            string url = "Employee/Count";
            HttpResponseMessage response;

            try
            {
                response = await APIconnection.ApiClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<int>();
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
    }

}
