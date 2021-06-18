using APIconnector.Processors;
using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.FilterCriterias;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Processors;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static DesktopAppTrouvaille.Globals.Globals;

namespace DesktopAppTrouvaille.Controllers
{
    public class OrderController : Controller
    {
        public MainController MainCont;
        public Order DetailOrder = new Order();
        public List<Order> Orders = new List<Order>();
        private IOrderProcessor _processor = new OrderProcessor();
        private ProductProcessor _productProcessor = new ProductProcessor();

        private OrderCriteria _filterCriteria;

        public OrderController(MainController mainController)
        {
            MainCont = mainController;
        }

        public async Task<List<Product>> GetProductsInOrder()
        {
            List<Product> products = new List<Product>();
            List<Guid> guids = new List<Guid>();
            if(DetailOrder.Products == null)
            {
                return products;
            }
            foreach(PostOrderProductViewModel p in DetailOrder.Products)
            {
                guids.Add(p.ProductId);
            }
            try
            {
                products = await _productProcessor.GetProductsByID(guids);
            }
            catch(Exception e)
            {
                _state = State.ConnectionError;
            }
            return products;
        }

        public override int GetCount()
        {
            return Orders.Count;
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
            /*// Test Code:
            Order order1 = new Order();
            order1.Date = DateTime.Now;
            order1.OrderState = Globals.Globals.OrderState.Bestellt;
      
            Orders.Add(order1);
            
            UpdateView();
            */
           
            try
            {
                _state = State.LoadData;
                _iterator.Count = await _processor.GetCount();
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
            try
            {
                _processor.UpdateOrder(order.OrderId, order.OrderState);
            }
            catch(Exception e)
            {
                _state = State.ConnectionError;
            }
        }

        public void DeleteOrder(Order order)
        {
            try
            {
                _processor.DeleteOrder(order.OrderId);
            }
            catch(Exception e)
            {
                _state = State.ConnectionError;
            }
        }

        public void ShowProduct(Product p)
        {
            MainCont.ShowProduct(p);
        }

        public int GetProductCount(Product p)
        {
            if(DetailOrder.Products == null)
            {
                return 0;
            }
            
            foreach(PostOrderProductViewModel product in DetailOrder.Products)
            {
                if(p.ProductId.Equals(product.ProductId))
                {
                    return product.Cardinality;
                }
            }
            return 0;
        }

        public void SetFilterCriteria(OrderCriteria criteria)
        {
            if(criteria != null)
            {
                _filterCriteria = criteria;
            }
        }

        public async override void Search(string searchText)
        { 
            DateTime timeFrom = _filterCriteria.OrderDateFrom;
            DateTime timeTo = _filterCriteria.OrderDateTo;
            OrderState state = _filterCriteria.OrderState;

            Console.WriteLine("From: " + timeFrom.ToString());
            Console.WriteLine("To: " + timeTo.ToString());
            try
            {
                Orders = await _processor.SearchOrders(_iterator.From, _iterator.To, new Guid(),timeFrom, timeTo,state);
            }
            catch(Exception e)
            {
                _state = State.ConnectionError;
            }
        }
    }
}
