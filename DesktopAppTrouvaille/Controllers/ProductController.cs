using APIconnector.Processors;
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Processors;
using DesktopAppTrouvaille.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille
{
    public enum State {ConnectionError, OK, LoadData , SendingData, SavedProduct, DeletedProduct}
    public class ProductController : IController
    {
        private int _productCount = 0;
        private ProductProcessor _productProssesor = new ProductProcessor();
        private CategoryProcessor _categoryProcessor = new CategoryProcessor();

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
        }

        public async void UpdateData()
        {
            try
            {
                _state = State.LoadData;
                Categories = await _categoryProcessor.LoadCategories();
                Products = await _productProssesor.LoadProducts(_iterator.From, _iterator.To);
                _state = State.OK;
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

        public async void SaveProduct(Product p)
        {
            _state = State.SendingData;
            // Call API
            if (await _productProssesor.SaveNewProduct(p))
            {
                UpdateData();
                _state = State.SavedProduct;
            }
            else
            {
                _state = State.ConnectionError;
            }
            
            _view.UpdateView();
            
        }

        public async void DeleteProduct(Product p)
        {
            _state = State.SendingData;
            // Call API
            if (await _productProssesor.DeleteProduct(p))
            {
                _state = State.DeletedProduct;
            }
            else
            {
                _state = State.ConnectionError;
            }
            _view.UpdateView();
            UpdateData();
        }

        public void ItemSelected(Product p)
        {
            //state = state.ItemSelected(this);
        }

        public async void UpdateProduct(Product p)
        {
            _state = State.SendingData;
            // Call API
            if ( await _productProssesor.UpdateProduct(p))
            {
                _state = State.SavedProduct;
            }
            else
            {
                _state = State.ConnectionError;
            }
            UpdateData();
            _view.UpdateView();
        }

       
    }
}
