using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Enums;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Processors;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DesktopAppTrouvaille.Views.EmployeeV
{
    public partial class EmployeeDetailView : DetailViewBase, IDetailView
    {
        protected EmployeeController _controller;
        protected Employee _customer = new Employee();

        public EmployeeDetailView()
        {
            InitializeComponent(); 
        }

        public EmployeeDetailView(EmployeeController controller)
        {
            InitializeComponent();
            textBoxFistName.Validating += textboxValidating;
            textBoxLastName.Validating += textboxValidating;
            textBoxEmail.Validating += textboxValidating;
            textBoxEmail.Validating += emailValidating;
            _controller = controller;
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

        protected void textboxValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider1.SetError(textBox, "Feld darf nicht leer sein!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        private void adressView1_Load(object sender, EventArgs e)
        {

        }

        protected Employee GetEmployeeFromInputField()
        {
            Employee em = new Employee();
         
            em.Id = _customer.Id;
            em.FirstName = textBoxFistName.Text;
            em.LastName = textBoxLastName.Text;
            em.Email = textBoxEmail.Text;
            return em;
        }
        protected virtual void ButtonSaveClick()
        {
            _controller.UpdateEmployee(GetEmployeeFromInputField());
        }

        // Button Save Click
        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                Enabled = false; // Disable View while Loading Data
                ButtonSaveClick();
            }
        }
        // Button Delete Click
        private void button2_Click(object sender, EventArgs e)
        {
            Enabled = false;
            _controller.DeleteEmployee(_customer);
        }

        public void SetModel(IModel model)
        {
            if(model is Employee)
            {
                _customer = (Employee)model;
            }
        }

        public void SetController(IController controller)
        {
            if(controller is EmployeeController)
            {
                _controller = (EmployeeController)controller;
            }
        }

        public override void UpdateView()
        {
            base.UpdateView();

            _customer = _controller.GetDetailEmployee();

            textBoxFistName.Text = _customer.FirstName;
            textBoxLastName.Text = _customer.LastName;
            textBoxEmail.Text = _customer.Email;
            labelEmailNotValid.Visible = false;
            if (_controller.GetError().Contains(Errors.UserAlreadyTaken))
            {
                labelEmailNotValid.Text = "Benutzer existiert Bereits!";
                labelEmailNotValid.Visible = true;
            }
        }
    }
}
