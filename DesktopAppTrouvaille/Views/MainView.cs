using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppTrouvaille.Views
{
    public partial class MainView : UserControl, IMainView
    {
        private IView _tabView;
        public MainView()
        {
            InitializeComponent();
        }

        public void SetTabView(IView view)
        {
            panelTabView.Controls.Add((UserControl)view);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _tabView = new ProductView();
            panelTabView.Controls.Clear();
            panelTabView.Controls.Add((UserControl)_tabView);
        }

        private void buttonShowOrders_Click(object sender, EventArgs e)
        {
            _tabView = new OrderViewUC();
            panelTabView.Controls.Clear();
            panelTabView.Controls.Add((UserControl)_tabView);
        }
    }
}
