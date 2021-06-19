using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;

namespace DesktopAppTrouvaille.Controllers
{
    public class CustomerController : Controller
    {
        private List<Customer> _customers = new List<Customer>();
        private Customer _detailCustomer = new Customer();

        public List<Customer> GetCustomers()
        {
            return _customers;
        }
        public Customer GetDetailCustomer()
        {
            return _detailCustomer;
        }
        public override int GetCount()
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<IModel> GetModels()
        {
            throw new NotImplementedException();
        }

        public override void Search(string searchText)
        {
            throw new NotImplementedException();
        }

        public override void SelectDetailModel(IModel model)
        {
            throw new NotImplementedException();
        }

        public override void UpdateData()
        {
            throw new NotImplementedException();
        }

        public async void UpdateCustomer(Customer customer)
        {
            
        }

        public async void DeleteCustomer(Customer customer)
        {

        }
    }
}
