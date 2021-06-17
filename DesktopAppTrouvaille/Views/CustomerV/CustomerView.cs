using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAppTrouvaille.Views;
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Factories;
using DesktopAppTrouvaille.Views.FilterV;

namespace DesktopAppTrouvaille.Views
{
    public partial class CustomerView : BView, IView
    {
        public CustomerView()
        {
            InitializeComponent();
            Controller = new CustomerController();
            Controller.AttachView(this);
            Controller.AttachView(listView);
            listView.Controller = Controller;
            listView.Factory = new CustomerItemFactory();
            listView.FilterView = new CustomerFiler();

            listView.Init();
        }

        public void UpdateView()
        {
            UpdateStatusLabel();
        }
        protected override IDetailView CreateDetailView(IModel model)
        {
            CustomerDetail view = new CustomerDetail();
           
            return view;
        }
    }
}
