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
            try
            {
                _state = State.LoadData;
                //_iterator.Count = _processor.GetCount();
                Categories = await _processor.LoadCategories();
                _state = State.OK;
            }
            catch (GETException)
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
                    UpdateView();
                    UpdateData();
                }
                else
                {
                    _state = State.DeleteFailed;
                }
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

        public async void SaveNewCategory(Category category)
        {
            try
            {
                if (await _processor.PostCategory(new CategoryPOSTDTO(category)))
                {
                    _state = State.Saved;
                    UpdateView();
                    UpdateData();
                }
                else
                {
                    _state = State.SaveFailed;
                }
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
        public async void UpdateCategory(Category category)
        {
            try
            {
                if( await _processor.UpdateCategory(category.CategoryId, category.Name))
                {
                    _state = State.Updated;
                    _detailCategory = category;
                    UpdateView();
                    UpdateData();
                }
                else
                {
                    _state = State.UpdateFailed;
                }
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

        public override IEnumerable<IModel> GetModels()
        {
            return Categories;
        }

        public override void SelectDetailModel(IModel model)
        {
            if(model != null && model is Category)
            {
                _detailCategory = (Category)model;
                UpdateView();
            }
        }

        public Category GetDetailCategory()
        {
            return _detailCategory;
        }

        public override void Search(string searchText)
        {
            //throw new NotImplementedException();
        }
    }
}
