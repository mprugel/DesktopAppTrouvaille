using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Factories;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Views.FilterV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppTrouvaille.Views
{
    public class ProductView : BView, IView
    {
        private ProductController _controller;
        public ProductView()
        {
            _controller = new ProductController();
            Controller = _controller;
            Controller.AttachView(this);
            Controller.AttachView(listView);

            // Init the ListView:
            listView.Controller = Controller;
            listView.Factory = new ProductItemFactory();
            listView.FilterView = new ProductFilter(_controller);
            
            listView.Init();

            Controller.UpdateData();
        }
        public void UpdateView()
        {
            UpdateStatusLabel();
            if(Controller.state == State.Saved)
            {
                panelDetailView.Visible = false;
            }
        }

        protected override IDetailView CreateNewView()
        {
           return new NewProductView((ProductController)Controller);
        }
        protected override IDetailView CreateDetailView(IModel model)
        {
            ProductDetailView view = new ProductDetailView();
            view.Controller = (ProductController)Controller;
            view.Prod = (Product)model;
            return view;
        }
    }
}
