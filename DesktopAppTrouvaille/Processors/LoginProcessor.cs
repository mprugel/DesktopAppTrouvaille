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
    public class LoginProcessor
    {
        public async Task<LoginResponse> LoginEmployee(LoginEmployeeModel employee)
        {
            string url = "Auth/Employee/Login";
            HttpResponseMessage response;

            string json = JsonConvert.SerializeObject(employee);
            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                response = await APIconnection.ApiClient.PostAsync(url, data);
                Console.WriteLine(response.ReasonPhrase);
                if (response.IsSuccessStatusCode)
                {  
                    return await response.Content.ReadAsAsync<LoginResponse>();
                }
                else
                {
                    return new LoginResponse();
                }
            }
            catch (Exception)
            {
                throw new GETException();
            }
        }
    

        public async Task<string> GetRole()
        {
            string url = "Auth/GetRole";
            HttpResponseMessage response;
            try
            {
                response = await APIconnection.ApiClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<string>();
                }
                else
                {
                    return "";
                }
            }
            catch (Exception)
            {
                throw new GETException();
            }
        }
    }
}
