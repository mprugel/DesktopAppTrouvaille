using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;


namespace DesktopAppTrouvaille.Factories
{
    public class CustomerItemFactory : ListItemFactory
    {
        public override string[] CreateColumns()
        {
            string[] cols = { "Vorname", "Nachname" };
            return cols;
        }

        protected override string[] CreateRowValues(IModel model)
        {
            Customer cust = (Customer)model;
            string[] row = { cust.FirstName, cust.LastName};
            return row;
        }

        public override void SetSortCriteria(int colmumnID, IController controller)
        {
            throw new System.NotImplementedException();
        }
    }
}
