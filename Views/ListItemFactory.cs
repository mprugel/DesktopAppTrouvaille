using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppTrouvaille.Views
{
    public abstract class ListItemFactory
    {
        public ListViewItem CreateListViewItem(IModel model)
        {
            string[] stringItems = CreateRowValues(model);
            ListViewItem item = new ListViewItem(stringItems, 1);
            item.Tag = model;
            return item;
        }
        
        protected abstract string[] CreateRowValues(IModel model);
       
    }
}
