using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppTrouvaille.Views
{
    class CustomListView : ListView
    {
        public CustomListView()
        {
            View = View.Details;

            FullRowSelect = true;
            GridLines = true;
            HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            HideSelection = false;
            MultiSelect = false;
            TabIndex = 7;
            TileSize = new System.Drawing.Size(100, 10);
            UseCompatibleStateImageBehavior = false;
        }

        public ListViewItem GetSelectedItem()
        {
            if (SelectedItems.Count > 0)
            {
                return SelectedItems[0];
            }
            else
            {
                return null;
            }
        }

        public void AddColumn(string colname)
        {
            Columns.Add(colname).Width = 100;
        }

        public void AddItems(List<object> items)
        {
            Items.Clear();
            foreach (ListViewItem itm in items)
            {
                Items.Add(itm);
            }
        }

        
    }
}
