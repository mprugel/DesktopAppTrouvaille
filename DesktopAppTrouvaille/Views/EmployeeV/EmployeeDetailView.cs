using DesktopAppTrouvaille.Controllers;
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
            _controller = controller;
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

        public virtual void UpdateView()
        {
            _customer = _controller.GetDetailEmployee();

            textBoxFistName.Text = _customer.FirstName;
            textBoxLastName.Text = _customer.LastName;
            textBoxEmail.Text = _customer.Email;
            labelEmailNotValid.Visible = false;
            if (_controller.GetError() == EmployeeProcessor.Errors.EmailInvalid)
            {        
                labelEmailNotValid.Visible = true;      
            }
        }
    }
}
