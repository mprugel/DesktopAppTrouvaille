using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.SortCreateria;

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

        protected override SortCreteria CreateSortCreteria(int colmumnID)
        {
            return null;
        }
    }
}
