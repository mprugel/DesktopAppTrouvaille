using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Enums;
using DesktopAppTrouvaille.Models;


namespace DesktopAppTrouvaille.Factories
{
    public class ProductItemFactory : ListItemFactory
    {
        public override string[] CreateColumns()
        {
           string[] cols = { "Name", "Lagerbestand", "Preis" };
           return cols;
        }

        protected override string[] CreateRowValues(IModel model)
        {
            Product p = (Product)model;
            string[] row = {  p.Name, p.InStock.ToString(), p.Price.ToString() };
            return row;
        }

        public override bool SetSortCriteria(int colmumnID, IController controller)
        {
            ProductController cont = (ProductController)controller;
            if(colmumnID == 2)
            {
                cont.SortCriteria = ProductSortCriteria.Price;
                return true;
            }
            return false;
        }
    }
}
