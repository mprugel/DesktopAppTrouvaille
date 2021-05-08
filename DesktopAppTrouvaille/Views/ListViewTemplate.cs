using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppTrouvaille.Views
{
    public partial class ListViewTemplate : UserControl
    {
        public ListViewTemplate()
        {
            InitializeComponent();
            listView1.View = View.Details;
      
        }
        public void AddClickHandler(EventHandler handler)
        {
            listView1.Click += handler;
        }

        public ListViewItem GetSelectedItem()
        {
            if(listView1.SelectedItems.Count > 0)
            { 
                return listView1.SelectedItems[0];
            }
            else
            {
                return null;
            }
        }

        public void AddColumn(string colname)
        {
            listView1.Columns.Add(colname);
        }

        public void AddItems(List<ListViewItem> items)
        {
            listView1.Items.Clear();
            foreach(ListViewItem itm in items)
            {
                listView1.Items.Add(itm);
            }
        }

        public void SetTitle(string title)
        {
            label1.Text = title;
        }

        
    }
}
