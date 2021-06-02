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

        public void SetOrder(Order order)
        {
            _order = order;
            adressViewDelivery.SetAdress(order.DeliveryAddress);
            adressViewOrder.SetAdress(order.InvoiceAddress);

            labelOrderDate.Text = order.Date.ToString();

            comboBoxOrderState.SelectedIndex = (int)order.OrderState;

        }

        public void UpdateView()
        {
            throw new NotImplementedException();
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
    }
}
