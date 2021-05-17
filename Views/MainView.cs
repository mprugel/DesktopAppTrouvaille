using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAppTrouvaille.Models;

namespace DesktopAppTrouvaille.Views
{
    public partial class MainView : UserControl, IMainView
    {
        private IView _tabView;
        private MainController controller;
        private List<ProductModel> _products = new List<ProductModel>();
        public MainView()
        {
            InitializeComponent();
            controller = new MainController();
        }
        public void UpdateView() 
        { 
         
        }
        public void SetTabView(IView view)
        {
            panelTabView.Controls.Add((UserControl)view);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductView view = new ProductView();
           
            _tabView = view;
            _tabView.UpdateView();
            panelTabView.Controls.Clear();
            panelTabView.Controls.Add((UserControl)_tabView);

        }

        private void buttonShowOrders_Click(object sender, EventArgs e)
        {
            _tabView = new OrderViewUC();
            panelTabView.Controls.Clear();
            panelTabView.Controls.Add((UserControl)_tabView);
        }

        private void buttonShowCategories_Click(object sender, EventArgs e)
        {
            _tabView = new CategoryView();
            panelTabView.Controls.Clear();
            panelTabView.Controls.Add((UserControl)_tabView);
        }

        private void buttonShowCustomers_Click(object sender, EventArgs e)
        {
            _tabView = new CustomerView();
            panelTabView.Controls.Clear();
            panelTabView.Controls.Add((UserControl)_tabView);
        }
    }
}
