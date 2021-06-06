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

        void UpdateData();

        void SetSortingOrder(SortingOrder order);

        SortingOrder GetSortingOrder();

        IEnumerable<IModel> GetModels();

        //void Filter(SortCriteria createria);

        void Previous();

        int GetCurrentPage();

        int GetPageCount();

        int GetCount();

        void Search(string searchText);

    }
}
