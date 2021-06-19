using APIconnector.Processors;
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Enums;
using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.FilterCriterias;
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
        public Product DetailProduct = new Product();

        public ProductSortCriteria SortCriteria = new ProductSortCriteria();
        private string _searchText = string.Empty;
        private ProductFilterCriteria FilterCriteria;

        // List of Products:
        public List<Product> Products = new List<Product>();

        public ProductController()
        {
            _iterator = new Iterator(10);
            _state = State.OK;
        }

        public async void  LoadCategories()
        {
            try
            {
                Categories = await _categoryProcessor.LoadCategories();
            }
            catch(Exception e)
            {
                _state = State.ConnectionError;
            }
        }

        public async override void UpdateData()
        {
            try
            {
                _state = State.LoadData;

                LoadCategories();
                if(FilterCriteria == null)
                {
                    _iterator.Count = await _productProssesor.GetProductCount();
                    Products = await _productProssesor.LoadProducts(_iterator.From, _iterator.To);
                }
                else
                {
                    Products = await _productProssesor.SearchAndFilter(_iterator.From, _iterator.To, _searchText, SortOrder, SortCriteria, FilterCriteria);
                }

               
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
            return  _iterator.Count;
        }


        public async void SaveProduct(Product p)
        {
            _state = State.SendingData;
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
            }
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
                UpdateView();
            }
            else
            {
                _state = State.ConnectionError;
            }
           
            UpdateData();
        }

    
        public async void UpdateProduct(Product oldP, Product newP)
        {
            if(oldP.ProductCategories == null)
            {
                oldP.ProductCategories = new List<Guid>();
            }
            // Get the Categories which are removed:
            List<Guid> removedCats = oldP.ProductCategories.Except(newP.ProductCategories).ToList();
            // Get the Categories which have been added:
            List<Guid> newCats = newP.ProductCategories.Except(oldP.ProductCategories).ToList();

            Console.WriteLine("New categories:");
            foreach(Guid g in newCats)
            {
                Console.WriteLine(g.ToString());
            }
            Console.WriteLine("----------------------------");

            // Save the newly added Categories:
            await _productProssesor.AddCategories(newP.ProductId, newCats);

            await _productProssesor.RemoveCategories(newP.ProductId, removedCats);

            //TODO: implement DeleteCategories:

            _state = State.SendingData;
            // Call API
            // Create PUT Model:
            PutProductModel putModel = new PutProductModel(newP);

            // Check if Picture has changed:
            if(oldP.Picture != null && oldP.Picture.ImageData != null && 
                newP.Picture != null && newP.Picture.ImageData != null &&
                !oldP.Picture.ImageData.SequenceEqual(newP.Picture.ImageData))
            {
                putModel.ImageData = newP.Picture.ImageData;
            }

            if ( await _productProssesor.UpdateProduct(newP.GetGuid(), putModel))
            {
                _state = State.Saved;
            }
            else
            {
                _state = State.ConnectionError;
            }

            DetailProduct = await _productProssesor.LoadProduct(newP.GetGuid());
            UpdateData();
            UpdateView();
        }

        public override IEnumerable<IModel> GetModels()
        {
            return this.Products;
        }

        public void SetFilter(ProductFilterCriteria filterCriteria )
        {
            FilterCriteria = filterCriteria;
        }

        public async override void SelectDetailModel(IModel model)
        {
           
            try
            {
                DetailProduct = await _productProssesor.LoadProduct(model.GetGuid());
            }
            catch
            {
                _state = State.ConnectionError;
            }
            finally
            {
                UpdateView();
            }
           
        }

        public async override void Search(string searchText)
        {
            _searchText = searchText;
            Console.WriteLine("Sortorder " + SortOrder);
            Console.WriteLine("SortCriteria " + SortCriteria);
            Console.WriteLine("FilterCrit " + FilterCriteria.CategroryID);

            try
            {
                Products = await _productProssesor.SearchAndFilter(_iterator.From, _iterator.To, searchText,SortOrder,SortCriteria, FilterCriteria);
                _iterator.Reset();
                _iterator.Count = Products.Count;
            }
            
            catch (Exception e)
            {
                _state = State.ConnectionError;
            }
            UpdateView();
        }
    }
}
