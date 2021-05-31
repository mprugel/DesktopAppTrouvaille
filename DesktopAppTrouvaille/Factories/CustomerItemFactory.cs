using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
