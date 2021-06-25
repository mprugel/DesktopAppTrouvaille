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
        private Manufacturer _detailManufacturer;
        public ProductSortCriteria SortCriteria = ProductSortCriteria.Price;
        private string _searchText = string.Empty;
        private ProductFilterCriteria FilterCriteria;

        // List of Products:
        public List<Product> Products = new List<Product>();

        public ProductController()
        {
            _iterator = new Iterator(10);
            _state = State.OK;
        }

        public Manufacturer GetManufacturer()
        {
            return _detailManufacturer;
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
              
                _iterator.Count = await _productProssesor.GetProductCount();
                Products = await _productProssesor.SearchAndFilter(_iterator.From, _iterator.To, _searchText, SortOrder, SortCriteria, FilterCriteria);
 
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


        public async void SaveProduct(Product p, Manufacturer manufacturer)
        {
            _state = State.SendingData;
            // Call API
            try
            {
                ProductPOSTDTO postDTO = new ProductPOSTDTO();
                postDTO.Description = p.Description;
                postDTO.InStock = (int)p.InStock;
                postDTO.MinStock = p.MinStock;
                postDTO.Name = p.Name;
                postDTO.Price = p.Price;
                postDTO.Tax = (decimal)p.Tax;
                

                postDTO.ManufacturerCatalogId = manufacturer.CatalogId;
                postDTO.ManufacturerEmail = manufacturer.Email;
                if(p.Picture != null && p.Picture.ImageData != null)
                {
                    postDTO.ImageData = p.Picture.ImageData;
                }
               
                if (await _productProssesor.SaveNewProduct(postDTO))
                {
                    UpdateData();
                    LoadDetailProduct(p.GetGuid());
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

    
        public async void UpdateProduct(Product oldP, Product newP, Manufacturer manufacturer)
        {
            if(oldP.ProductCategories == null)
            {
                oldP.ProductCategories = new List<Guid>();
            }
            // Get the Categories which are removed:
            List<Guid> removedCats = oldP.ProductCategories.Except(newP.ProductCategories).ToList();
            // Get the Categories which have been added:
            List<Guid> newCats = newP.ProductCategories.Except(oldP.ProductCategories).ToList();


            // Save the newly added Categories:
            await _productProssesor.AddCategories(newP.ProductId, newCats);

            // Remove Categories:
            await _productProssesor.RemoveCategories(newP.ProductId, removedCats);

            _state = State.SendingData;

            // Call API
            // Create PUT Model:
            PutProductModel putModel = new PutProductModel(newP);
            putModel.ManufacturerCatalogId = manufacturer.CatalogId;
            putModel.ManufacturerEmail = manufacturer.Email;

            // Check if Picture has changed:
            if( (oldP.Picture.ImageData == null && newP.Picture.ImageData != null) || 
                (newP.Picture != null && newP.Picture.ImageData != null &&
                !oldP.Picture.ImageData.SequenceEqual(newP.Picture.ImageData))
              )
            {
                putModel.ImageData = newP.Picture.ImageData;
            }

            if ( await _productProssesor.UpdateProduct(newP.GetGuid(), putModel))
            {
                DetailProduct = newP;
                _state = State.Saved;
            }
            else
            {
                _state = State.ConnectionError;
            }
            UpdateData();
        }

        public override IEnumerable<IModel> GetModels()
        {
            return this.Products;
        }

        public void SetFilter(ProductFilterCriteria filterCriteria )
        {
            FilterCriteria = filterCriteria;
        }
        public async void LoadDetailProduct(Guid guid)
        {
            try
            {
                if (DetailProduct != null && DetailProduct.ManufacturerId != null)
                {
                    _detailManufacturer = await _productProssesor.GetManufacturerByID((Guid)DetailProduct.ManufacturerId);
                }
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

        public override void SelectDetailModel(IModel model)
        {
            DetailProduct = (Product)model;
            LoadDetailProduct(model.GetGuid());
        }

        public async override void Search(string searchText)
        {
            _searchText = searchText;
            try
            {
                _iterator.Reset();
                _iterator.Count = await _productProssesor.GetProductCount();
                Products = await _productProssesor.SearchAndFilter(_iterator.From, _iterator.To, searchText,SortOrder,SortCriteria, FilterCriteria);
                
            }

            catch (Exception e)
            {
                _state = State.ConnectionError;
            }
            UpdateView();
        }
    }
}
