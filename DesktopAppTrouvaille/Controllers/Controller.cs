using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Controllers
{
    // This Controller Class contains Functions which are used by all specific Controllers.
    class Controller : IController
    {
        // Iterator:
        private Iterator _iterator;

        public int GetCurrentPage()
        {
           return _iterator.CurrentPage;
        }

        public int GetPageCount()
        {
            return _iterator.Count;
        }

        public void Next()
        {
            _iterator.Next();
        }

        public void Previous()
        {
            _iterator.Previous();
        }

        public int GetCount()
        {
            return 0;
        }
    }
}
