using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Views.EmployeeV;

namespace DesktopAppTrouvaille.Views
{
    public partial class MainView : UserControl, IMainView
    {
       
        private IView _tabView;
        private List<Button> buttons = new List<Button>();
        private Color _buttonActiveColor = Color.FromArgb(160, 212, 250);
        private Color _buttonForeColorActive = Color.FromArgb(0, 0, 0);
        private Color _buttonColor;

        private MainController controller;
        private List<Product> _products = new List<Product>();

        public MainView()
        {
            InitializeComponent();
            controller = new MainController(this);
            UpdateView();
            _buttonColor = buttonLogout.BackColor;

            buttons.Add(buttonShowCategories);
            buttons.Add(buttonShowCustomers);
            buttons.Add(buttonShowEpmloyees);
            buttons.Add(buttonShowProducts);
            buttons.Add(buttonShowOrders);
        }

        private void ResetButtonsColor()
        {
            foreach(Button btn in buttons)
            {
                btn.BackColor = _buttonColor;
                btn.ForeColor = Color.White;
            }
        }

        public void ShowProductView()
        {
            ProductDetailView view = new ProductDetailView();
            view.Controller = controller.productController;
            controller.productController.AttachView(view);
            _tabView = view;
            panelTabView.Controls.Clear();
            panelTabView.Controls.Add((UserControl)_tabView);
        }

        public void UpdateView() 
        {
            if(MainController.LoggedIn)
            {
                panelMainMenu.Visible = true;
                panelTabView.Controls.Clear();
            }
            else
            {
                LoginView view = new LoginView(controller);
                view.Left = (ClientSize.Width - view.Width) / 2;
                view.Top = (ClientSize.Height - view.Height) / 2;

                _tabView = view;
                panelMainMenu.Visible = false;
                panelTabView.Controls.Clear();
                panelTabView.Controls.Add((UserControl)_tabView);
            }
        }
        public void SetTabView(IDetailView view)
        {
            panelTabView.Controls.Add((UserControl)view);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetButtonsColor();
            ProductView view = new ProductView();
            view.Dock = DockStyle.Fill;
           
            _tabView = view;
            _tabView.UpdateView();
            panelTabView.Controls.Clear();
            panelTabView.Controls.Add((UserControl)_tabView);
            buttonShowProducts.BackColor = _buttonActiveColor;
            buttonShowProducts.ForeColor = _buttonForeColorActive;

        }

        private void buttonShowOrders_Click(object sender, EventArgs e)
        {
            ResetButtonsColor();

            buttonShowOrders.BackColor = _buttonActiveColor;
            buttonShowOrders.ForeColor = _buttonForeColorActive; 
            OrderViewUC orderView = new OrderViewUC(new OrderController(controller));
            orderView.Dock = DockStyle.Fill;
            _tabView = orderView;
            panelTabView.Controls.Clear();
            panelTabView.Controls.Add((UserControl)_tabView);
        }

        private void buttonShowCategories_Click(object sender, EventArgs e)
        {
            ResetButtonsColor();

            buttonShowCategories.BackColor = _buttonActiveColor;
            buttonShowCategories.ForeColor = _buttonForeColorActive;
            CategoryView view = new CategoryView();
            view.Dock = DockStyle.Fill;
            _tabView = view;
            panelTabView.Controls.Clear();
            panelTabView.Controls.Add((UserControl)_tabView);
        }

        private void buttonShowCustomers_Click(object sender, EventArgs e)
        {
            ResetButtonsColor();

            buttonShowCustomers.BackColor = _buttonActiveColor;
            buttonShowCustomers.ForeColor = _buttonForeColorActive;
            CustomerView view = new CustomerView(new CustomerController(controller));
            view.Dock = DockStyle.Fill;
            _tabView = view;
            panelTabView.Controls.Clear();
            panelTabView.Controls.Add((UserControl)_tabView);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            controller.Logout();
        }

        private void buttonShowRatings_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowEpmloyees_Click(object sender, EventArgs e)
        {
            ResetButtonsColor();

            buttonShowEpmloyees.BackColor = _buttonActiveColor;
            buttonShowEpmloyees.ForeColor = _buttonForeColorActive;
            EmployeeView view = new EmployeeView(new EmployeeController());
            view.Dock = DockStyle.Fill;
            _tabView = view;
            panelTabView.Controls.Clear();
            panelTabView.Controls.Add((UserControl)_tabView);
        }

        private void buttonShowProducts_Leave(object sender, EventArgs e)
        {
            
        }

        public void ShowOrderView()
        {
            _tabView = new OrderViewUC(controller.orderController);
            panelTabView.Controls.Clear();
            panelTabView.Controls.Add((UserControl)_tabView);
        }
    }
}
