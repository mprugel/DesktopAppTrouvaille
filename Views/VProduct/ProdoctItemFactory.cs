using DesktopAppTrouvaille.Models;


namespace DesktopAppTrouvaille.Views.Product
{
    public class ProdoctItemFactory : ListItemFactory
    {
        protected override string[] CreateRowValues(IModel model)
        {
            Models.Product p = (Models.Product)model;
            string[] row = { p.ProductId.ToString(), p.Name, p.InStock.ToString() };
            return row;
        }
    }
}
