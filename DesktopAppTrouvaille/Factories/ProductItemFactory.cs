using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Factories
{
    public class ProductItemFactory : ListItemFactory
    {
        public override string[] CreateColumns()
        {
           string[] cols = { "ID", "Name", "Lagerbestand" };
           return cols;
        }

        protected override string[] CreateRowValues(IModel model)
        {
            Product p = (Product)model;
            string[] row = { p.ProductId.ToString(), p.Name, p.InStock.ToString() };
            return row;
        }
    }
}
