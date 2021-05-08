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
        public Product Prod { get; set; }
        public ProductDetailView()
        {
            InitializeComponent();
        }
        public void UpdateView()
        {
            labelProductID.Text = Prod.ProductID.ToString();
            textBoxName.Text = Prod.Name.ToString();
            numericUpDownInStock.Value = Prod.InStock;
            numericUpDownPrice.Value = (int)Prod.Price;
            richTextBox1.Text = Prod.Description;
        }

        public void SetTitle(string title)
        {
            labelTitle.Text = title;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool CheckInputFields()
        {
            bool ret = false;
            if(textBoxName.Text.Length == 0)
            {
                textBoxName.BackColor = Color.Red;
                ret = false;
            }

            if(numericUpDownPrice.Value <= 0)
            {
                numericUpDownPrice.BackColor = Color.Red;
                ret = false;
            }

            if(richTextBox1.Text.Length == 0)
            {
                richTextBox1.BackColor = Color.Red;
                ret = false;
            }

            return ret;
        }

        
    }
}
