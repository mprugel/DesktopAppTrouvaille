using System;

using System.Windows.Forms;
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;

namespace DesktopAppTrouvaille.Views
{
    public partial class CustomerDetail : UserControl, IDetailView
    {
        public CustomerController Controller;
        public Customer customer;
        public CustomerDetail()
        {
            InitializeComponent();
        }

        public void SetController(IController controller)
        {
            Controller = (CustomerController)controller;
        }

        public void SetModel(IModel model)
        {
            customer = (Customer)model;
            // Display the Values on the GUI:
        }

        public void UpdateView()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
