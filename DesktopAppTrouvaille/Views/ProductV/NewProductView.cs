using System;
using System.Windows.Forms;
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
            Enabled = true;

        }

        protected override void buttonSave_Click(object sender, EventArgs e)
        {
            if ( ValidateChildren(ValidationConstraints.Enabled)) 
            {
                Controller.SaveProduct(GetProductFromInputs(),GetManufacturerFromInput());
            }
        }
    }
}
