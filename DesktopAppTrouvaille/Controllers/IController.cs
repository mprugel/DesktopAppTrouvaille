using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Controllers
{
    public interface IController
    {
        void Next();

        void ItemSelected(IModel model);

        IModel GetSelectedModel();

        void Previous();

        int GetCurrentPage();

        int GetPageCount();

        int GetCount();
    }
}
