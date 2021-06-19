

using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Processors
{
    public interface ICustomerProcessor
    {
        Task<List<Customer>> GetCustomers(int from, int to);
        Task<Customer> SearchCustomer(int from, int to, Guid customerId, string customerEmail);
        Task<int> GetCount();
        Task<bool> UpdateCustomer(Customer customer);
        Task<bool> DeleteCustomer(Customer customer);
    }
}
