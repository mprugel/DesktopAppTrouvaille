using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Factories;
using DesktopAppTrouvaille.Models;
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
        
        public ProductView()
        {
            Controller = new ProductController();

            // Init the ListView:
            listView.Controller = Controller;
            listView.Factory = new ProductItemFactory();
            listView.Init();
        }
        public void UpdateView()
        {
            
        }

        protected override IView CreateNewView()
        {
           return new NewProductView((ProductController)Controller);
        }
        protected override IView CreateDetailView(IModel model)
        {
            ProductDetailView view = new ProductDetailView();
            view.Controller = (ProductController)Controller;
            view.Prod = (Product)model;
            return view;
        }
    }
}
