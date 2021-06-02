using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Processors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryProcessor _processor = new CategoryProcessor();
        private List<Category> _categories = new List<Category>();

        public override int GetCount()
        {
            return _categories.Count();
        }

        public override async void UpdateData()
        {
            try
            {
                _categories = await _processor.LoadCategories();
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

       
    }
}
