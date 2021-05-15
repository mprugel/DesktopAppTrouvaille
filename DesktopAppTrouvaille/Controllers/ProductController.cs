using APIconnector.Processors;
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille
{
    public enum State {ConnectionError, OK, LoadProducts , SavedProduct}
    public class ProductController
    {
        private ProductProcessor prossesor = new ProductProcessor();

        public List<Category> Categories = new List<Category>();

        private State _state;

        private ProductIterator _iterator;
        public State state { get { return _state; } }


        // List of Products:
        public List<Product> Products = new List<Product>();

        // Interface for Updating the GUI:
        private IView _view;

        public ProductController(IView view)
        {
            _iterator = new ProductIterator(10);
            _state = State.OK;
            _view = view;
            //---------------------------------------
            // TEST CODE:
            /*Categories = new List<Category>();
            Category cat1 = new Category();
            cat1.Name = "Künstlerpinsel";
            Category cat2 = new Category();
            cat2.Name = "Farben";
            Categories.Add(cat1);
            Categories.Add(cat2);
           

            Products = new List<Product>();
            Product p1 = new Product();
            p1.Categories = Categories;
            p1.Name = "Pinsel Größe 5";
            p1.Price = 2;
            p1.ProductID = 45;

            Product p2 = new Product();
            p2.Name = "Pinsel Größe 10";
            p2.Price = 3;
            p2.ProductID = 51;
            p2.Categories = Categories;

            Products.Add(p1);
            Products.Add(p2);
            */
            //---------------------------------------
            //TEST
        }

        public async void UpdateData()
        {
            try
            {
                _state = State.LoadProducts;
                Products = await prossesor.LoadProducts(_iterator.From, _iterator.To);
            }
            catch(GETException e)
            {
                _state = State.ConnectionError;
            }
            finally
            {
                _view.UpdateView();
            }
        }

        public void Next()
        {
            _iterator.Next();
            UpdateData();
        }

        public void Previous()
        {
            _iterator.Previous();
            UpdateData();
        }

        public bool SaveProduct(Product p)
        {
            // Call API
            if(prossesor.SaveProduct(p).Result)
            {
                _state = State.SavedProduct;
                _view.UpdateView();
                return true;
            }
            else
            {
                _state = State.ConnectionError;
                _view.UpdateView();
                return false;
            }

        }

        public void ItemSelected(Product p)
        {
            //state = state.ItemSelected(this);
        }

        public void UpdateProduct(Product p)
        {
            // Call API 
            //...
            
            _view.UpdateView();
        }

       
    }
}
