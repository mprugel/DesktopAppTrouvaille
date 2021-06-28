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
        private Category _detailCategory = new Category();

        public override int GetCount()
        {
            return Categories.Count();
        }

        public override async void UpdateData()
        {
            try
            {
                _iterator.Count = await  _processor.GetCategoryCount();
                Categories = await _processor.LoadCategoriesFromTo(_iterator.From, _iterator.To);
            }
            catch (GETException)
            {
                _state = State.ConnectionError;
            }
            finally { UpdateView(); }
        }

        public async void DeleteCategory(Category category)
        {
            _locked = true;
            try
            {
                if (await _processor.DeleteCategory(category.GetGuid()))
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
            _locked = true;
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
            _locked = true;
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
            _selectedModel = model;
            if (model != null && model is Category)
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
