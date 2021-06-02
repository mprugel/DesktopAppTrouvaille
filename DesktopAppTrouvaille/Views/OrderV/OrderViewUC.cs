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
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Factories;

namespace DesktopAppTrouvaille.Views
{
    public partial class OrderViewUC : BView, IView
    {
        public OrderViewUC()
        {
            InitializeComponent();
            Controller = new OrderController();
            Controller.AttachView(this);
            Controller.AttachView(listView);
            listView.Controller = Controller;
            listView.Factory = new OrderItemFactory();
            listView.Init();
        }

        public void UpdateView()
        {
            UpdateStatusLabel();
        }

        protected override IDetailView CreateDetailView(IModel model)
        {
            OrderDetailView view = new OrderDetailView();
            return view;
        }
    }
}
