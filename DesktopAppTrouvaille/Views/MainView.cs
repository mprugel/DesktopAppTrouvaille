﻿using System;
using System.Collections.Generic;

using System.Windows.Forms;
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Views.EmployeeV;

namespace DesktopAppTrouvaille.Views
{
    public partial class MainView : UserControl, IMainView
    {
        private IView _tabView;
        private MainController controller;
        private List<Product> _products = new List<Product>();
        public MainView()
        {
            InitializeComponent();
            controller = new MainController(this);
            UpdateView();
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
                _tabView = new LoginView(controller);
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
            ProductView view = new ProductView();
           
            _tabView = view;
            _tabView.UpdateView();
            panelTabView.Controls.Clear();
            panelTabView.Controls.Add((UserControl)_tabView);

        }

        private void buttonShowOrders_Click(object sender, EventArgs e)
        {
            OrderViewUC orderView = new OrderViewUC(new OrderController(controller));
 
            _tabView = orderView;
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
            _tabView = new EmployeeView(new EmployeeController());
            panelTabView.Controls.Clear();
            panelTabView.Controls.Add((UserControl)_tabView);
        }

       
    }
}
