﻿
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;
using System.Windows.Forms;

namespace DesktopAppTrouvaille.Views.EmployeeV
{
    public partial class NewEmployeeView : EmployeeDetailView
    {
        public NewEmployeeView()
        {
            InitializeComponent();
            
        }
        public NewEmployeeView(EmployeeController controller) : base(controller)
        {
            InitializeComponent();
            textBoxPassword.Validating += textboxValidating;
            textBoxPasswordReType.Validating += textboxValidating;
           
        }

        protected override void ButtonSaveClick()
        {
            // Check if Passwords are Equal:
            if(textBoxPassword.Text.Equals(textBoxPasswordReType.Text))
            {
                Employee employee = GetEmployeeFromInputField();
                RegisterEmployeeModel registerModel = new RegisterEmployeeModel(employee,textBoxPassword.Text,textBoxPasswordReType.Text);
                _controller.SaveNewEmployee(registerModel);
            }
           
        }
    }
}
