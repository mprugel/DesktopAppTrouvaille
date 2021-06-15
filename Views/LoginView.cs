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
using DesktopAppTrouvaille.Models;

namespace DesktopAppTrouvaille.Views
{
    public partial class LoginView : UserControl, IView
    {
        private IMainController _controller;
        public LoginView()
        {
            InitializeComponent();
        }

        public LoginView(IMainController controller)
        {         
            _controller = controller;
            InitializeComponent();
        }

        public void UpdateView()
        {
            throw new NotImplementedException();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // TODO: Check input
            _controller.Login(new User());
        }
    }
}
