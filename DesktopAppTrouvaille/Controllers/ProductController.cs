using APIconnector.Processors;
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Processors;
using System;
using System.Collections.Generic;
using System.Linq;




namespace DesktopAppTrouvaille
{    
    public class ProductController : Controller
    {
        private ProductProcessor _productProssesor = new ProductProcessor();
        private CategoryProcessor _categoryProcessor = new CategoryProcessor();

        public List<Category> Categories = new List<Category>();

        // List of Products:
        public List<Product> Products = new List<Product>();

        public ProductController()
        {
            _iterator = new Iterator(10);
            _iterator.Count = 30;
            _state = State.OK;
        }

        public async override void UpdateData()
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
                UpdateView();
            }
        }

        public override int GetCount()
        {
            // TODO -> Call API:
            return 100;
        }


        public async void SaveProduct(Product p)
        {
            /*_state = State.SendingData;
            // Call API
            try
            {
                if (await _productProssesor.SaveNewProduct(p))
                {
                    UpdateData();
                    _state = State.Saved;
                }
                else
                {
                    _state = State.ConnectionError;
                }
            }
            catch(GETException e)
            {
                _state = State.ConnectionError;
            }*/
            _state = State.Saved;
            UpdateView();
            
        }

        public async void DeleteProduct(Product p)
        {
            _state = State.SendingData;
            // Call API
            if (await _productProssesor.DeleteProduct(p))
            {
                _state = State.Deleted;
            }
            else
            {
                _state = State.ConnectionError;
            }
           
            UpdateView();
            UpdateData();
        }

        public void ItemSelected(Product p)
        {
            //state = state.ItemSelected(this);
        }

        public async void UpdateProduct(Product oldP, Product newP)
        {
            // Get the Categories which are removed:
            List<Guid> removedCats = (List<Guid>)newP.ProductCategories.Except(oldP.ProductCategories);
            // Get the Categories which have been added:
            List<Guid> newCats = (List<Guid>)oldP.ProductCategories.Except(newP.ProductCategories);

            // Save the newly added Categories:
            await _productProssesor.AddCategories(newP.ProductId, newCats);

            //TODO: implement DeleteCategories:

            _state = State.SendingData;
            // Call API
            if ( await _productProssesor.UpdateProduct(newP))
            {
                _state = State.Saved;
            }
            else
            {
                _state = State.ConnectionError;
            }
            
            UpdateData();
            UpdateView();
        }

        public override IEnumerable<IModel> GetModels()
        {
            return this.Products;
        }
    }
}
