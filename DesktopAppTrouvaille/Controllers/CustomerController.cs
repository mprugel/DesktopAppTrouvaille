using DesktopAppTrouvaille.Enums;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Processors;
using System;
using System.Collections.Generic;

namespace DesktopAppTrouvaille.Controllers
{
    public class CustomerController : Controller
    {
        private List<Customer> _customers = new List<Customer>();
        private Customer _detailCustomer = new Customer();
        private CustomerSortCriteria _customerSortCriteria;
        private ICustomerProcessor _processor = new CustomerProcessor();
        private MainController _mainController;

        public CustomerController(MainController mainController)
        {
            _mainController = mainController;
        }
        public void SetSortCriteria(CustomerSortCriteria criteria)
        {
            _customerSortCriteria = criteria;   
        }
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
            return _customers.Count;
        }

        public override IEnumerable<IModel> GetModels()
        {
            return _customers;
        }

        public override void Search(string searchText)
        {
            
        }

        public override void SelectDetailModel(IModel model)
        {
            if(model is Customer && model != null)
            {
                _detailCustomer = (Customer)model;
                UpdateView();
            }
        }

        public async override void UpdateData()
        {
            _state = State.LoadData;
            UpdateView();
            try
            {
                _iterator.Count = await _processor.GetCount();
                _customers = await _processor.GetCustomers(_iterator.From, _iterator.To);
                _state = State.OK;
            }
            catch (Exception e)
            {
                _state = State.ConnectionError;
            }
            finally
            {
                UpdateView();
            }
        }

        public async void UpdateCustomer(Customer customer)
        {
            try
            {
                if(await _processor.UpdateCustomer(customer))
                {
                    _state = State.Saved;
                }
            }
            catch
            {
                _state = State.ConnectionError;
            }
        }

        public async void DeleteCustomer(Customer customer)
        {
            try
            {
                if (await _processor.DeleteCustomer(customer))
                {
                    _state = State.Deleted;
                }
            }
            catch
            {
                _state = State.ConnectionError;
            }
        }

        public void ShowOrders()
        {

        }
    }
}
