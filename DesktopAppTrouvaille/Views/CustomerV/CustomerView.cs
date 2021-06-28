using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;

using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Factories;
using DesktopAppTrouvaille.Views.FilterV;

namespace DesktopAppTrouvaille.Views
{
    public partial class CustomerView : BView, IView
    {
        private CustomerController _controller;
        public CustomerView(CustomerController controller)
        {
            InitializeComponent();
            _controller = controller;
            Controller = _controller;
            Controller.AttachView(this);
            Controller.AttachView(listView);
            listView.Controller = Controller;
            listView.Factory = new CustomerItemFactory();
            listView.FilterView = new CustomerFiler(_controller);

            listView.Init();

            _controller.UpdateData();

        }
        public CustomerView()
        {
            InitializeComponent();
        }

        public void UpdateView()
        {
            UpdateStatusLabel();
        }
        protected override IDetailView CreateDetailView(IModel model)
        {
            CustomerDetail view = new CustomerDetail(_controller);
           
            return view;
        }
    }
}
