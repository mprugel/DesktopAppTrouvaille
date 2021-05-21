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
        private ProductProcessor _productProssesor = new ProductProcessor();
        private CategoryProcessor _categoryProcessor = new CategoryProcessor();

        public List<Category> Categories = new List<Category>();

        private State _state;

        private Iterator _iterator;
        public State state { get { return _state; } }

        // List of Products:
        public List<Product> Products = new List<Product>();

        // Interface for Updating the GUI:
        private IView _view;

        public ProductController(IView view)
        {
            _iterator = new Iterator(10);
            _iterator.Count = 30;
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

        public int GetCount()
        {
            // TODO -> Call API:
            return 100;
        }

        public int GetCurrentPage()
        {
            return _iterator.CurrentPage ;
        }

        public void Next()
        {
            _iterator.Next();
            _view.UpdateView();
            UpdateData();
        }

        public void Previous()
        {
            _iterator.Previous();
            _view.UpdateView();
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

        public async void UpdateProduct(Product oldP, Product newP)
        {
            // Get the Categories which are removed:
            
            await _productProssesor.AddCategories(newP.ProductId, newP.Categories);

            _state = State.SendingData;
            // Call API
            if ( await _productProssesor.UpdateProduct(newP))
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

        public int GetPageCount()
        {
            return _iterator.Count / _iterator.StepSize;
        }
    }
}
