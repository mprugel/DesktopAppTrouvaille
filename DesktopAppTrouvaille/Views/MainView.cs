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
        private List<Product> _products = new List<Product>();
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
            ProductView view = new ProductView();
            Product p1 = new Product();
            p1.Name = "Pinsel Größe 5";
            p1.Price = 2;
            p1.ProductID = 45;

            Product p2 = new Product();
            p2.Name = "Pinsel Größe 10";
            p2.Price = 3;
            p2.ProductID = 51;

            _products.Add(p1);
            _products.Add(p2);
            view.Products = _products;
           
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
    }
}
