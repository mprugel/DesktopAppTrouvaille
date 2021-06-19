using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAppTrouvaille.Controllers;

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
           
        }

        protected override void ButtonSaveClick()
        {
            _controller.SaveNewEmployee(GetEmployeeFromInputField());
        }
    }
}
