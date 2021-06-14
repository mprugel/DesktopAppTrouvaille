using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Controllers;
using static DesktopAppTrouvaille.Globals.Globals;

namespace DesktopAppTrouvaille.Views
{
    public partial class OrderDetailView : UserControl, IDetailView
    {
        private Order _order;

        public OrderController Controller;

        public OrderDetailView()
        {
            InitializeComponent();

            // Init the Combobox for selecting the order state:
            comboBoxOrderState.Items.Add(Globals.Globals.OrderState.cancelled);
            comboBoxOrderState.Items.Add(Globals.Globals.OrderState.payed);
            comboBoxOrderState.Items.Add(Globals.Globals.OrderState.shipped);
        }


        public void UpdateView()
        {

            // Display Values on the GUI:
            adressViewDelivery.SetAdress(_order.DeliveryAddress);
            adressViewOrder.SetAdress(_order.InvoiceAddress);

            labelOrderDate.Text = _order.Date.ToString();
            labelSum.Text = _order.TotalCost.ToString();
            comboBoxOrderState.DataSource = Globals.Globals.OrderStateDic.ToList();
            comboBoxOrderState.DisplayMember = "Value";
            comboBoxOrderState.ValueMember = "Key";

            comboBoxOrderState.SelectedIndex = (int)_order.OrderState;

            //Display Products of Order in ListView:
            dataGridView1.Rows.Clear();
            foreach(Product product in Controller.GetProductsInOrder())
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row =dataGridView1.Rows[rowId];

                Button btn = new Button();
                btn.Text = ">";

                // Add the data
                row.Cells[0].Value = product.Name;
                row.Cells[1].Value = product.Price;
            }
            

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
            UpdateView(); 
        }

        public void SetController(IController controller)
        {
            Controller = (OrderController)controller;
        }

        //Button save click:
        private void button2_Click(object sender, EventArgs e)
        {
            bool valid1 = adressViewDelivery.CheckInputFields();
            bool valid2 = adressViewOrder.CheckInputFields();
            if (valid1 && valid2)
            {
                Controller.UpdateOrder(GetOrderFromInputFields());
            }
        }

        // Button delete Click:
        private void button1_Click(object sender, EventArgs e)
        {
            Controller.DeleteOrder(_order);
        }

        private void labelOrderDate_Click(object sender, EventArgs e)
        {

        }
    }
}
