using DesktopAppTrouvaille.Exceptions;
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
            UpdateData();
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
            try
            {
                 Orders = await _processor.LoadOrders(_iterator.From, _iterator.To);
            }
            catch(GETException e)
            {
                _state = State.ConnectionError;
            }
           
            UpdateView();
        }
    }
}
