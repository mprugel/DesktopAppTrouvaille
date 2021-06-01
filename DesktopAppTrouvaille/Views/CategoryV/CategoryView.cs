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
using DesktopAppTrouvaille.Factories;

namespace DesktopAppTrouvaille.Views
{
    public partial class CategoryView : BView, IView, IBView
    {
        public CategoryView()
        {
            InitializeComponent();
            Controller = new CategoryController();
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

        IView IBView.CreateDetailView(IModel model)
        {
            CategoryDetailView view = new CategoryDetailView();
            return view;
        }

        IView IBView.CreateNewView()
        {
            return null;
        }
    }
}
