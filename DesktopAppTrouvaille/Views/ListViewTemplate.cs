using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAppTrouvaille.Controllers;

namespace DesktopAppTrouvaille.Views
{
    public partial class ListViewTemplate : UserControl , IView
    {
        public IController Controller;
        public ListViewTemplate()
        {
            InitializeComponent();
            listView1.View = View.Details;
        }

        public ListViewTemplate(IController controller)
        {
            Controller = controller;
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
            listView1.Columns.Add(colname).Width = 100;
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

        public void SetButtonText(string name)
        {
            buttonAdd.Text = name;
        }

        public void AddButtonAddHandler(EventHandler handler)
        {
            buttonAdd.Click += handler;
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            Controller.Previous();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Controller.Next();
        }

        public void UpdateView()
        {
            labelPageCount.Text = Controller.GetPageCount().ToString();
            labelPageNumber.Text = Controller.GetCurrentPage().ToString();
        }
    }
}
