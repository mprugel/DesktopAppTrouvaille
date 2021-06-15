using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppTrouvaille.Factories
{
    public class OrderProductFactory : ListItemFactory
    {
        public override string[] CreateColumns()
        {
            string[] cols = {"Name", "Einzelpreis", "Menge", "Summe"};
            return cols;
        }

        public override void SetSortCriteria(int colmumnID, IController controller)
        {
            
        }
        protected override ListViewItem CreateListViewItem(IModel model)
        {
            Button button = new Button();
            button.Text = "Zum Produkt";
            string[] stringItems = CreateRowValues(model);
            ListViewItem item = new ListViewItem(stringItems, 1);
            ListViewItem buttonItem = new ListViewItem();

            item.Tag = model;
            return item;
        }

        protected override string[] CreateRowValues(IModel model)
        {
           string[] row= {"-", "-", "-", "-" };
           if(model is Product)
           {
                Product product = (Product)model;
                row[0] = product.Name;
                row[1] = product.Price.ToString();
           }
           return row;
        }
    }
}
