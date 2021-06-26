using APIconnector;
using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Processors
{

    public class EmployeeProcessor
    {
        private Errors _error;
        public Errors Error { get { return _error; } }
        public enum Errors { NoError, PasswordInvalid, EmailInvalid}

        private void SetError(ErrorViewModel response)
        {
            if(response == null || response.Errors == null)
            {
                return;
            }
            if(response.Errors != null)
            {
                _error = Errors.EmailInvalid;
            }
            if (response.Errors != null)
            {
                _error = Errors.PasswordInvalid;
            }
        }
        public async Task<bool> RegisterNewEmployee(RegisterEmployeeModel employee)
        {
            string url = "Auth/Employee/Register";
            HttpResponseMessage response;

            string json = JsonConvert.SerializeObject(employee);
            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                response = await APIconnection.ApiClient.PostAsync(url, data);
                Console.WriteLine(response);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    ErrorViewModel error = await response.Content.ReadAsAsync<ErrorViewModel>();
                    SetError(error);
                    return false;
                }
            }
            catch (Exception)
            {
                throw new GETException();
            }
        }

        public async Task<bool> UpdateEmployee(Guid guid,Employee employee)
        {
            string url = "Auth/Employee?employeeId=" + guid.ToString();
            HttpResponseMessage response;

            string json = JsonConvert.SerializeObject(employee);
            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                response = await APIconnection.ApiClient.PutAsync(url, data);
                Console.WriteLine(response);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    ErrorViewModel error = await response.Content.ReadAsAsync<ErrorViewModel>();
                    SetError(error);
                    return false;
                }
            }
            catch (Exception)
            {
                throw new GETException();
            }
        }

        public async Task<List<Employee>> GetEmployees(int from , int to)
        {
            string url = string.Format("Auth/Employee/{0}/{1}", from, to);
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
            catch (Exception)
            {
                throw new GETException();
            }
        }

        public async Task<int> GetCount()
        {
            string url = "Auth/Employee/Count";
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
            catch (Exception)
            {
                throw new GETException();
            }
        }

        public async Task<bool> DeleteEmployee(Guid guid)
        {
            string url = string.Format("Auth/Employee/{0}", guid.ToString());
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

    }

}
