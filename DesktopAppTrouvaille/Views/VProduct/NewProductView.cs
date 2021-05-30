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
            Prod.Categories = new List<Category>();
            UpdateView();
            
            this.DisplayDeleteButton(false);
            this.SetTitle("Neues Produkt anlegen");
            this.SetButtonText("Produkt anlegen");

        }

        protected override void buttonSave_Click(object sender, EventArgs e)
        {
            if(CheckInputFields())
            {
                Controller.SaveProduct(GetProductFromInputs());
            }
        }
    }
}
