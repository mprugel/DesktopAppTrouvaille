using System;
using System.ComponentModel;
using System.Windows.Forms;
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;

namespace DesktopAppTrouvaille.Views
{
    public partial class CustomerDetail : DetailViewBase, IDetailView
    {
        public CustomerController Controller;
        private Customer _customer;
        public CustomerDetail()
        {
            InitializeComponent();
            textBoxEmail.Validating += textBox_Validating;
            textBoxPhoneNumber.Validating += textBox_Validating;
            textBoxFirstName.Validating += textBox_Validating;
            textBoxLastName.Validating += textBox_Validating;

        }
        public CustomerDetail(CustomerController controller)
        {
            InitializeComponent();
            textBoxEmail.Validating += textBox_Validating;
            textBoxPhoneNumber.Validating += textBox_Validating;
            textBoxFirstName.Validating += textBox_Validating;
            textBoxLastName.Validating += textBox_Validating;

            textBoxEmail.Validating += emailValidating;
            Controller = controller;
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider1.SetError(textBox, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        public void SetController(IController controller)
        {
            Controller = (CustomerController)controller;
        }

        public void SetModel(IModel model)
        {
            _customer = (Customer)model;
            // Display the Values on the GUI:
        }

        public override void UpdateView()
        {
            base.UpdateView();

            _customer = Controller.GetDetailCustomer();
            textBoxEmail.Text = _customer.Email;
            textBoxFirstName.Text = _customer.FirstName;
            textBoxLastName.Text = _customer.LastName;
            textBoxPhoneNumber.Text = _customer.PhoneNumber;

            adressViewDelivery.SetAdress(_customer.DeliveryAddress);
            adressViewInvoice.SetAdress(_customer.InvoiceAddress);

            checkBoxActive.Checked = _customer.IsDisabled;
            labelError.Text = string.Empty;
            if(Controller.GetError().Contains(Enums.Errors.UserAlreadyTaken))
            {
                labelError.Text = "E-Mail ist schon vergeben!";
            }
            
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void emailValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!IsValidEmail(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider1.SetError(textBox, "E-Mail Adresse ist nicht gültig!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        private Customer GetCustomerFromInputFields()
        {
            Customer customer = new Customer();
            customer.Id = _customer.Id;
            customer.DeliveryAddress = adressViewDelivery.GetAddressFromView();
            customer.InvoiceAddress = adressViewInvoice.GetAddressFromView();

            customer.FirstName = textBoxFirstName.Text;
            customer.LastName = textBoxLastName.Text;
            customer.PhoneNumber = textBoxPhoneNumber.Text;
            customer.Email = textBoxEmail.Text;
            customer.IsDisabled = checkBoxActive.Checked;

            return customer;
        }

        private bool CheckInputFields()
        {
            
            return true;
        }

        // Button Deactivate Click:
        private void button1_Click(object sender, EventArgs e)
        {
            Controller.DeleteCustomer(_customer);
        }

        // Button Save Click:
        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Controller.UpdateCustomer(GetCustomerFromInputFields());
            }
        }

        // Button click show orders:
        private void button3_Click(object sender, EventArgs e)
        {
            Controller.ShowOrders();
        }
    }
}
