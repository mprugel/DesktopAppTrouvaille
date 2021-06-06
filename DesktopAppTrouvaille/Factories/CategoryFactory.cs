using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.SortCreateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Factories
{
    public class CategoryFactory : ListItemFactory
    {
        public override string[] CreateColumns()
        {
            string[] cols = { "Name", "Anzahl Produkte" };
            return cols;
        }

        protected override string[] CreateRowValues(IModel model)
        {
            Category cat = (Category)model;
            string[] row = {cat.Name, cat.ProductCounter.ToString()};
            return row;
        }

        protected override SortCreteria CreateSortCreteria(int colmumnID)
        {
            throw new NotImplementedException();
        }
    }
}
