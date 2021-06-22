using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Enums;
using DesktopAppTrouvaille.Factories;
using DesktopAppTrouvaille.Models;

namespace DesktopAppTrouvaille.Views
{

    // Base Class For ListView: Can be extended if necessary.
    public partial class ListViewTemplate : UserControl, IView
    {
        private SortOrder _sortOrder;
        public IController Controller;
        public ListItemFactory Factory;
        // Properties for setting in the Designer:
        public string Title { get { return label1.Text; } set { label1.Text = value; } }
        public string AddButtonText { get { return buttonAdd.Text; } set { buttonAdd.Text = value; } }

        private Filter _filterView;
        public Filter FilterView {
            get { return _filterView; }
            set 
            {
                if(value != null && value is Filter)
                {
                    _filterView = value;
                    Control view = value;
                    view.Location = new Point(10, 20);
                    groupBox1.Controls.Add(value); 
                }
                
            } }

        private bool _displayAddButton = true;

        private bool _displayFilterView = true;
        public bool DisplayFilterView
        {
            get { return _displayFilterView; }
            set
            {
                _displayFilterView = value;
                groupBox1.Visible = value;

            }
        }

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
            //listView1.View = View.Details;
            _sortOrder = SortOrder.Ascending;
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
            // Display Models from Controller in ListView:
            listView1.Items.Clear();
            List<ListViewItem> items = Factory.CreateListViewItems(Controller.GetModels());
            foreach(ListViewItem item in items)
            {
                listView1.Items.Add(item);
                if(item.Tag.Equals(Controller.GetSelectedModel()))
                {
                    item.Selected = true;
                    listView1.Select();
                }   
            }
            // Update Labels:
            labelPageCount.Text = Controller.GetPageCount().ToString();
            labelPageNumber.Text = Controller.GetCurrentPage().ToString();
        }

        // Search Button Click:
        private void button1_Click(object sender, EventArgs e)
        {
            if(FilterView != null)
            {
                FilterView.SendFilterToController();
                Controller.Search(textBox1.Text);
            }
           
        }

        // Method for setting Arrow Symbol in Columnheader:
        private void SetSortArrow(ColumnHeader head, SortOrder order)
        {
            const string ascArrow = " ▲";
            const string descArrow = " ▼";

            // remove arrow
            if (head.Text.EndsWith(ascArrow) || head.Text.EndsWith(descArrow))
                head.Text = head.Text.Substring(0, head.Text.Length - 2);

            // add arrow
            switch (order)
            {
                case SortOrder.Ascending: head.Text += ascArrow; break;
                case SortOrder.Descending: head.Text += descArrow; break;
            }
        }

        private static int lastColumn;
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
            if(_sortOrder == SortOrder.Ascending || lastColumn != e.Column)
            {
                _sortOrder = SortOrder.Descending;
                Controller.SetSortingOrder(SortingOrder.Descending);
            }
            else 
            { 
                _sortOrder = SortOrder.Ascending;
                Controller.SetSortingOrder(SortingOrder.Ascending);
            }

            foreach(ColumnHeader header in listView1.Columns)
            {
                SetSortArrow(header, SortOrder.None);
            }
            lastColumn = e.Column;
           
            if(Factory.SetSortCriteria(e.Column, Controller))
            {
                SetSortArrow(listView1.Columns[e.Column], _sortOrder);
                Controller.UpdateData();
            }
            

        }
    }
}
