using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Factories;
using DesktopAppTrouvaille.Models;

namespace DesktopAppTrouvaille.Views
{

    // Base Class For ListView: Can be extended if necessary.
    public partial class ListViewTemplate : UserControl , IView
    {
        public IController Controller;
        public ListItemFactory Factory;
        // Properties for setting in the Designer:
        public string Title { get { return label1.Text; } set { label1.Text = value; } }
        public string AddButtonText { get { return buttonAdd.Text; } set { buttonAdd.Text = value; } }

        private bool _displayAddButton = true;
        public bool DisplayAddButton { get { return _displayAddButton; } 
            set 
            { 
                _displayAddButton = value;
                buttonAdd.Visible = value;
            } 
        }
       
        public ListViewTemplate()
        {
            InitializeComponent();
        }

        public void Init()
        {
            listView1.View = View.Details;

            // Add cols:
            foreach (string col in Factory.CreateColumns())
            {
                listView1.Columns.Add(col).Width = 100;
            }
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
            if (listView1.Items.Count > 0)
            {
                foreach(ListViewItem item in listView1.Items)
                {
                    if(item.Tag.Equals(Controller.GetSelectedModel()))
                    {
                        item.Selected = true;
                    }
                }
               
                listView1.Select();
            }
            labelPageCount.Text = Controller.GetPageCount().ToString();
            labelPageNumber.Text = Controller.GetCurrentPage().ToString();
        }
    }
}
