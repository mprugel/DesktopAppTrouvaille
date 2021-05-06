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
    public partial class ProductDetailView : UserControl
    {
        private Product _product;

        public Product Prod { get; set; }
        public ProductDetailView()
        {
            InitializeComponent();
        }
        public void UpdateView()
        {
            labelProductID.Text = Prod.ProductID.ToString();
            labelProductName.Text = Prod.Name.ToString();
            numericUpDownInStock.Value = Prod.InStock;
            numericUpDownPrice.Value = (int)Prod.Price;
            richTextBox1.Text = Prod.Description;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
