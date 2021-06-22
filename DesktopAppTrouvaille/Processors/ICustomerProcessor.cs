

using DesktopAppTrouvaille.FilterCriterias;
using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Processors
{
    public interface ICustomerProcessor
    {
        Task<List<Customer>> GetCustomers(int from, int to);
        Task<List<Customer>> SearchCustomer(int from, int to, CustomerFilter filter);
        Task<int> GetCount();
        Task<bool> UpdateCustomer(PutCustomerModel customer, Guid guid);
        Task<bool> DeleteCustomer(Customer customer);
    }
}
