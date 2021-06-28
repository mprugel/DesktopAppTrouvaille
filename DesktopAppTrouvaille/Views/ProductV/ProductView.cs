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
            this.listView.Size = new System.Drawing.Size(427, 696);
            this.listView.Load += new System.EventHandler(this.listView_Load);
            // 
            // panelDetailView
            // 
            this.panelDetailView.Size = new System.Drawing.Size(0, 696);
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(1138, 696);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listView_Load(object sender, EventArgs e)
        {

        }
    }
}
