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

        public override int GetCount()
        {
            return Categories.Count();
        }

        public override async void UpdateData()
        {
            try
            {
                Categories = await _processor.LoadCategories();
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
            throw new NotImplementedException();
        }
    }
}
