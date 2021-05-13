using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppTrouvaille.Views
{
    public partial class NewProductView : ProductDetailView
    {
        public NewProductView()
        {
            InitializeComponent();
            this.Prod = new Models.Product();
            this.UpdateView();
            this.DisplayDeleteButton(false);
            this.SetTitle("Neues Produkt anlegen");
            this.SetButtonText("Produkt anlegen");
        }
        public NewProductView(ProductController controller): base(controller)
        {
           
        }
    }
}
