using System;

using DesktopAppTrouvaille.Models;

namespace DesktopAppTrouvaille.Views
{
    public partial class NewProductView : ProductDetailView
    {
        public NewProductView()
        {
            InitializeComponent();
        }
        public NewProductView(ProductController controller) : base(controller)
        {
            InitializeComponent();
            Prod = new Product();
            //UpdateView();
            categorySelection1.AddCategories(Prod.ProductCategories, Controller.Categories);

            this.DisplayDeleteButton(false);
            this.SetTitle("Neues Produkt anlegen");
            this.SetButtonText("Produkt anlegen");

        }

        protected override void buttonSave_Click(object sender, EventArgs e)
        {
            if(CheckInputFields())
            {
                Controller.SaveProduct(GetProductFromInputs(),GetManufacturerFromInput());
            }
        }
    }
}
