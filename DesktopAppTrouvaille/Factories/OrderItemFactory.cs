using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;


namespace DesktopAppTrouvaille.Factories
{
    class OrderItemFactory : ListItemFactory
    {
        public override string[] CreateColumns()
        {
            string[] cols = { "Datum", "Status", "Betrag in €" };
            return cols;
        }

        protected override string[] CreateRowValues(IModel model)
        {
            Order order = (Order)model;
            string[] row = { order.Date.ToString("dd.MM.yyyy"), Globals.Globals.OrderStateDic[order.OrderState], order.TotalCost.ToString()};
            return row;
        }

        public override bool SetSortCriteria(int colmumnID, IController controller)
        {
            if(controller is OrderController)
            {
                OrderController orderController = (OrderController)controller;
                switch(colmumnID)
                {
                    case 0:
                        orderController.SetSortCriteria(Enums.OrderSortCriteria.Date);
                        return true;

                }
                return false;
            }
            return false;
        }
    }
}
