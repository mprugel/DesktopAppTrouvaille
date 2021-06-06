using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;


namespace DesktopAppTrouvaille.Factories
{
    class OrderItemFactory : ListItemFactory
    {
        public override string[] CreateColumns()
        {
            string[] cols = { "Datum", "Status" };
            return cols;
        }

        protected override string[] CreateRowValues(IModel model)
        {
            Order order = (Order)model;
            string[] row = { order.Date.ToString(), order.OrderState.ToString() };
            return row;
        }

        public override void SetSortCriteria(int colmumnID, IController controller)
        {
            
        }
    }
}
