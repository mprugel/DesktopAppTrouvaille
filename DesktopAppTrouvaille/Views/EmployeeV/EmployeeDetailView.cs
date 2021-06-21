using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DesktopAppTrouvaille.Views.EmployeeV
{
    public partial class EmployeeDetailView : DetailViewBase, IDetailView
    {
        protected EmployeeController _controller;
        protected Employee _customer;

        public EmployeeDetailView()
        {
            InitializeComponent();
            textBoxFistName.Validating += textboxValidating;
            textBoxLastName.Validating += textboxValidating;
        }

        public EmployeeDetailView(EmployeeController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void textboxValidating(object sender, CancelEventArgs e)
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
            return em;
        }
        protected virtual void ButtonSaveClick()
        {

        }

        // Button Save Click
        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                ButtonSaveClick();
            }
        }
        // Button Delete Click
        private void button2_Click(object sender, EventArgs e)
        {

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

        public void UpdateView()
        {
            
        }
    }
}
