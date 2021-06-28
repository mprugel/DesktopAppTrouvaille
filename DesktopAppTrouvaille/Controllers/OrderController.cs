using APIconnector.Processors;
using DesktopAppTrouvaille.Enums;
using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.FilterCriterias;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Processors;
using System;
using System.Collections.Generic;


namespace DesktopAppTrouvaille.Controllers
{
    public class OrderController : Controller
    {
        public MainController MainCont;
        public Order DetailOrder = new Order();
        public List<Order> Orders = new List<Order>();
        private IOrderProcessor _processor = new OrderProcessor();
        private ProductProcessor _productProcessor = new ProductProcessor();
        private OrderSortCriteria _sortCriteria;
        private OrderCriteria _filterCriteria = new OrderCriteria();

        private List<Product> _products = new List<Product>();

        public OrderController(MainController mainController)
        {
            MainCont = mainController;
        }

        public List<Product> GetProductsInOrder()
        {
            return _products;
            
        }

        public override int GetCount()
        {
            return Orders.Count;
        }

        public override IEnumerable<IModel> GetModels()
        {
            return Orders;
        }

        public async override void SelectDetailModel(IModel model)
        {
            DetailOrder = (Order)model;

            List<Guid> guids = new List<Guid>();
            if (DetailOrder.Products == null)
            {
                return;
            }
            foreach (PostOrderProductViewModel p in DetailOrder.Products)
            {
                guids.Add(p.ProductId);
            }
            try
            {
                _products = await _productProcessor.GetProductsByID(guids);
            }
            catch (Exception)
            {
                _state = State.ConnectionError;
            }
            
            UpdateView();
        }


        public async override void UpdateData()
        {
          
            try
            {
                _state = State.LoadData;
               _iterator.Count = await _processor.GetCount();
                Orders = await _processor.SearchOrders(_iterator.From, _iterator.To, _filterCriteria, _sortCriteria, SortOrder);
                _state = State.OK;
            }
            catch (GETException)
            {
                _state = State.ConnectionError;
            }
            finally
            {
                 UpdateView();
            }
           
           
        }

        public void UpdateOrder(Order order)
        {
            try
            {
                _processor.UpdateOrder(order.OrderId, order.OrderState);
                DetailOrder = order;
            }
            catch (Exception)
            {
                _state = State.ConnectionError;
            }
            finally
            {
                UpdateData();
            }
        }

        public void DeleteOrder(Order order)
        {
            try
            {
                _processor.DeleteOrder(order.OrderId);
            }
            catch (Exception)
            {
                _state = State.ConnectionError;
            }
            finally
            {
                UpdateData();
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

        public OrderCriteria GetFilter()
        {
            return _filterCriteria;
        }

        public async override void Search(string searchText)
        {
            try
            {
                _iterator.Reset();
                _iterator.Count = await _processor.GetCount();
                if(searchText.Length > 0)
                {
                    Guid.TryParse(searchText, out _filterCriteria.CustomerGuid);
                    _filterCriteria.FilerID = true;
                }
                else
                {
                    _filterCriteria.FilerID = false;
                }
                Orders = await _processor.SearchOrders(_iterator.From, _iterator.To, _filterCriteria, _sortCriteria, SortOrder);
                _searchText = searchText;
                UpdateView();
            }
            catch (Exception)
            {
                _state = State.ConnectionError;
            }
            finally
            {
                UpdateView();
            }
        }

        public void SetSortCriteria(OrderSortCriteria criteria)
        {
            _sortCriteria = criteria;
        }

    }
}
