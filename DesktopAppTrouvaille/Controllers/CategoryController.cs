using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Processors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesktopAppTrouvaille.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryProcessor _processor = new CategoryProcessor();
        public List<Category> Categories = new List<Category>();
        private Category _detailCategory;

        public override int GetCount()
        {
            return Categories.Count();
        }

        public override async void UpdateData()
        {
            _state = State.LoadData;
            try
            {
                //_iterator.Count = _processor.GetCount();
                Categories = await _processor.LoadCategories();
                _state = State.OK;
            }
            catch(GETException e)
            {
                _state = State.ConnectionError;
            }
            finally { UpdateView(); }
        }

        public async void DeleteCategory(Category category)
        {
            try
            {
                if (await _processor.PostCategory(new CategoryPOSTDTO(category)))
                {
                    _state = State.Deleted;
                }
                else
                {
                    _state = State.ConnectionError;
                }
            }
            catch (Exception e)
            {
                _state = State.ConnectionError;
            }
            finally
            {
                UpdateData();
                UpdateView();
            }
        }

        public async void SaveNewCategory(Category category)
        {
            try
            {
                if (await _processor.PostCategory(new CategoryPOSTDTO(category)))
                {
                    _state = State.Saved;
                }
                else
                {
                    _state = State.ConnectionError;
                }
            }
            catch(Exception e)
            {
                _state = State.ConnectionError;
            }
            finally 
            {
                UpdateData();
                UpdateView(); 
            }
        }
        public void UpdateCategory(Category category)
        {
            
        }

        public override IEnumerable<IModel> GetModels()
        {
            return Categories;
        }

        public override void SelectDetailModel(IModel model)
        {
            if(model != null && model is Category)
            {
                _detailCategory = (Category)model;
            }
        }

        public Category GetDetailCategory()
        {
            return _detailCategory;
        }

        public override void Search(string searchText)
        {
            throw new NotImplementedException();
        }
    }
}
