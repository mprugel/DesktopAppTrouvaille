using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Factories;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Views.FilterV;
using System;


namespace DesktopAppTrouvaille.Views
{
    public class ProductView : BView, IView
    {
        private ProductController _controller;
        private ProductFilter filterView;
        public ProductView()
        {
            _controller = new ProductController();
            Controller = _controller;
            Controller.AttachView(this);
            Controller.AttachView(listView);

            // Init the ListView:
            listView.Controller = Controller;
            listView.Factory = new ProductItemFactory();
            filterView = new ProductFilter(_controller);
            _controller.AttachView(filterView);
            listView.FilterView = filterView;
            
            listView.Init();

            Controller.UpdateData();
      
        }
        public void UpdateView()
        {
            UpdateStatusLabel();
            if(Controller.state == State.Saved || Controller.state == State.Deleted)
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
            ProductDetailView view = new ProductDetailView(_controller);
            view.Prod = (Product)model;
            return view;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Load += new System.EventHandler(this.listView_Load);
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.Name = "ProductView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listView_Load(object sender, EventArgs e)
        {

        }
    }
}
