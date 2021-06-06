using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.SortCreateria;
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

        IEnumerable<IModel> GetModels();

        void SetSortCreteria(SortCreteria createria);

        void Previous();

        int GetCurrentPage();

        int GetPageCount();

        int GetCount();

        void Search(string searchText);

    }
}
