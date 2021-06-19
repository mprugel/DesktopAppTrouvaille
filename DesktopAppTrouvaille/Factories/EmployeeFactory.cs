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
            string[] cols = { "Vorname", "Nachname" };
            return cols;
        }

        public override void SetSortCriteria(int colmumnID, IController controller)
        {
            throw new NotImplementedException();
        }

        protected override string[] CreateRowValues(IModel model)
        {
            string[] row;
            if(model is Employee)
            {
                //...
            }
            return null;
        }
    }
}
