﻿using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Processors;
using System;
using System.Collections.Generic;

namespace DesktopAppTrouvaille.Controllers
{
    public class OrderController : Controller
    {
        public Order DetailOrder = new Order();
        public List<Order> Orders = new List<Order>();
        private OrderProcessor _processor = new OrderProcessor();

        public OrderController()
        {
            
        }

        public List<Product> GetProductsInOrder()
        {
            List<Product> prods = new List<Product>();
            Product p1 = new Product();
            p1.Name = "Pinsel";
            p1.Price = 3;
            prods.Add(p1);
            return prods;
        }

        public override int GetCount()
        {
            // TODO: Call API:
            return 100;
        }

        public override IEnumerable<IModel> GetModels()
        {
            return Orders;
        }

        public override void SelectDetailModel(IModel model)
        {
            DetailOrder = (Order)model;
        }

        public async override void UpdateData()
        {
            // Test Code:
            Order order1 = new Order();
            order1.Date = DateTime.Now;
            order1.OrderState = Globals.Globals.OrderState.payed;

            Orders.Add(order1);
            UpdateView();
            try
            {
                _state = State.LoadData;
                 Orders = await _processor.LoadOrders(_iterator.From, _iterator.To);
                _state = State.OK;
            }
            catch(GETException e)
            {
                _state = State.ConnectionError;
            }
           
            UpdateView();
        }

        public void UpdateOrder(Order order)
        {

        }

        public void DeleteOrder(Order order)
        {

        }
    }
}
