using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAppTrouvaille.FilterCriterias;
using DesktopAppTrouvaille.Controllers;

namespace DesktopAppTrouvaille.Views.FilterV
{
    public partial class CustomerFiler : Filter
    {
        private CustomerController _controller;

        private CustomerFilter _filter = new CustomerFilter(false,"");
        public CustomerFiler()
        {
            InitializeComponent();
        }

        public CustomerFiler(CustomerController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        public CustomerFilter GetFilter()
        {
            return _filter;
        }

        public override void SendFilterToController()
        {
            _controller.SetFilter(GetFilter());
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            _filter.OnlyActive = checkBox2.Checked;
        }
    }
}
