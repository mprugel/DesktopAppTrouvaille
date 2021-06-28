
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Enums;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Processors;
using System.ComponentModel;
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
            
            textBoxPassword.Validating += passwordValidating;
            textBoxPasswordReType.Validating += passwordValidating;
            Enabled = true;
        }
        public override void UpdateView()
        {
            base.UpdateView();

            labelPasswordNotValid.Visible = false;
            if (_controller.GetError().Contains(Errors.PasswordInvalid))
            {
                labelPasswordNotValid.Text = "Passwort erfüllt die Kriterien nicht!";
                labelPasswordNotValid.Visible = true;
            }
          
        }
        private void passwordValidating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!textBoxPassword.Text.Equals(textBoxPasswordReType.Text))
            {
                e.Cancel = true;
                
                errorProvider1.SetError(textBox, "Die Passwörter müssen übereinstimmem!");
            }
            else if(
                    textBoxPassword.Text.Length < 6 || textBoxPassword.Text.Length > 50 ||
                    textBoxPasswordReType.Text.Length < 6 || textBoxPasswordReType.Text.Length > 50
                )
            {
                e.Cancel = true;
                
                errorProvider1.SetError(textBox, "Die Passwortlänge muss zwischen 6 und 50 Zeichen betragen!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
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
