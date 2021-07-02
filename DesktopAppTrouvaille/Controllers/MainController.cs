﻿using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille;
using DesktopAppTrouvaille.Views;
using DesktopAppTrouvaille.FilterCriterias;
using System.Windows.Forms;
using DesktopAppTrouvaille.Processors;
using System;

namespace DesktopAppTrouvaille
{
    // This Class handles the login and logout
    public class MainController : IMainController
    {
        private static bool _loggedIn;
        public static bool LoggedIn { get { return _loggedIn; } }
        private static bool _isAdmin;
        public static bool IsAdmin { get { return _isAdmin; } }
        private IMainView _view;

        public ProductController productController = new ProductController();
        public OrderController orderController;

        private LoginProcessor _loginProcessor = new LoginProcessor();

        private State _state = State.OK;

        private bool _locked = false;
        public bool IsLocked {get{ return _locked; } }

        public MainController(IMainView view)
        {
            _view = view;
            _loggedIn = false;
        }

        public async void Login(LoginEmployeeModel user)
        {
           /* _loggedIn = true;
            _isAdmin = true;
            _view.UpdateView();
            return;*/
          
            // Call API to Login User:
            try
            {
                LoginResponse response = await _loginProcessor.LoginEmployee(user);
                if (response != null && response.IsSuccess)
                {
                    APIconnector.APIconnection.SetToken(response.Message);
                    string role = await _loginProcessor.GetRole();
                    if(role.Equals("Admin")|| role.Equals("Employee"))
                    {
                        if(role.Equals("Admin"))
                        {
                            _isAdmin = true;
                        }
                        else
                        {
                            _isAdmin = false;
                        }
                        //Successfuly logged in:
                        _loggedIn = true;
                        _state = State.LoggedIn;
                    }
                }
                else
                {
                    _state = State.LoginFailed;
                }

            }
            catch(Exception)
            {
                _state = State.ConnectionError;
            }
            _view.UpdateView();
        }

        public void Logout()
        {
            _loggedIn = false;
            _view.UpdateView();
        }

        public async void ShowProduct(Product p)
        {
            productController = new ProductController();
            _view.ShowProductView();

            await productController.LoadCategories();
            productController.SelectDetailModel(p);

        }

        public void ShowOrders(Customer customer)
        {
            orderController = new OrderController(this);
            _view.ShowOrderView();
            
            orderController.Search(customer.GetGuid().ToString());
        }

       

        public State GetState()
        {
            return _state;
        }
    }
}
