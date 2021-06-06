using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;


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

        public override void SetSortCriteria(int colmumnID, IController controller)
        {
            ProductController cont = (ProductController)controller;
            switch(colmumnID)
            {
                case 1:
                    cont.SortCriteria = ProductSortCriteria.Name;
                    break;
                case 2:
                    cont.SortCriteria = ProductSortCriteria.InStock;
                    break;

            }
        }
    }
}
