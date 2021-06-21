using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Controllers;
using static DesktopAppTrouvaille.Globals.Globals;

namespace DesktopAppTrouvaille.Views
{
    public partial class OrderDetailView : DetailViewBase, IDetailView
    {
        private Order _order;

        public OrderController Controller;

        public OrderDetailView()
        {
            InitializeComponent();

            dataGridView1.Columns[3].Tag = (Action<Product>)ToProductClickHandler;

        }


        public void UpdateView()
        {

            // Display Values on the GUI:
            _order = Controller.DetailOrder;
           
            adressViewDelivery.SetAdress(_order.DeliveryAddress);
            adressViewOrder.SetAdress(_order.InvoiceAddress);

           
            labelOrderDate.Text = _order.Date.ToString();
            labelSum.Text = _order.TotalCost.ToString();

            comboBoxOrderState.DataSource = Globals.Globals.OrderStateDic.ToList();
            comboBoxOrderState.DisplayMember = "Value";
            comboBoxOrderState.ValueMember = "Key";

            comboBoxOrderState.SelectedValue = _order.OrderState;

            //Display Products of Order in ListView:
            dataGridView1.Rows.Clear();
            
            foreach(Product product in Controller.GetProductsInOrder())
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];
                row.Tag = product;

                Button btn = new Button();
                btn.Text = ">";

                // Add the data
                row.Cells[0].Value = product.Name;
                row.Cells[1].Value = product.Price;
                row.Cells[2].Value = Controller.GetProductCount(product);
            }
            

        }
        public void ToProductClickHandler(Product p)
        {
            Console.WriteLine("Go to Product: " + p.Name);
            Controller.ShowProduct(p);
        }
        private Order GetOrderFromInputFields()
        {
            Order newOrder = new Order(_order);
            newOrder.OrderState = ((KeyValuePair<OrderState,string>)comboBoxOrderState.SelectedItem).Key;
            return newOrder;
        }


        private void adressViewDelivery_Load(object sender, EventArgs e)
        {

        }

        public void SetModel(IModel model)
        {
            _order = (Order)model;
             
        }

        public void SetController(IController controller)
        {
            Controller = (OrderController)controller;
        }

        //Button save click:
        private void button2_Click(object sender, EventArgs e)
        {
            Controller.UpdateOrder(GetOrderFromInputFields()); 
        }

        // Button delete Click:
        private void button1_Click(object sender, EventArgs e)
        {
            Controller.DeleteOrder(_order);
        }

        private void labelOrderDate_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
            {
                //They clicked the header column, do nothing
                return;
            }

            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                var clickHandler = (Action<Product>)grid.Columns[e.ColumnIndex].Tag;
                var product = (Product)grid.Rows[e.RowIndex].Tag;

                clickHandler(product);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelSum_Click(object sender, EventArgs e)
        {

        }
    }
}
