using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Controllers;

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

            comboBoxOrderState.SelectedIndex = (int)_order.OrderState;
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
