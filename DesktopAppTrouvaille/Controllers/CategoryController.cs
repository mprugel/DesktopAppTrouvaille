using DesktopAppTrouvaille.Exceptions;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Processors;
using System;
using System.Collections.Generic;
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
    }
}
