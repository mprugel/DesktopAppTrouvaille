using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Factories
{
    public class EmployeeFactory : ListItemFactory
    {
        public override string[] CreateColumns()
        {
            string[] cols = { "Vorname", "Nachname", "E-Mail" };
            return cols;
        }

        public override bool SetSortCriteria(int colmumnID, IController controller)
        {
            return false;
        }

        protected override string[] CreateRowValues(IModel model)
        {
           
            if(model is Employee)
            {
                Employee em = (Employee)model;
                string[] row = {em.FirstName, em.LastName, em.Email};
                return row;
            }
            return new string[1];
        }
    }
}
