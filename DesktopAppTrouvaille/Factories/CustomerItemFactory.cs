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

        public override bool SetSortCriteria(int colmumnID, IController controller)
        {
            if(!(controller is CustomerController))
            {
                return false;
            }
            CustomerController customerController = (CustomerController)controller;
            switch(colmumnID)
            {
                case 0:
                    customerController.SetSortCriteria(Enums.CustomerSortCriteria.Firstname);
                    return true;
                   
                case 1:
                    customerController.SetSortCriteria(Enums.CustomerSortCriteria.Lastname);
                    return true;
               
            }
            return false;
        }
    }
}
