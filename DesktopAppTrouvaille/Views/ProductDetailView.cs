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
        private bool newProduct = false;

        private Product _prod;
        public Product Prod;

        public ProductController Controller;
        public ProductDetailView()
        {
            InitializeComponent();

            // Init the Category List:

        }
        public ProductDetailView(ProductController controller)
        {
            InitializeComponent();
            Controller = controller;
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

        public void DisplayDeleteButton(bool isVisible)
        {
            buttonDelete.Visible = isVisible;
        }

        public void SetButtonText(string text)
        {
            buttonSave.Text = text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool CheckInputFields()
        {
            bool ret = true;
            if(textBoxName.Text.Length == 0)
            {
                textBoxName.BackColor = Color.Red;
                ret = false;
            }
            else
            {
                textBoxName.BackColor = Color.White;
            }

            if(numericUpDownPrice.Value <= 0)
            {
                numericUpDownPrice.BackColor = Color.Red;
                ret = false;
            }
            else
            {
                numericUpDownPrice.BackColor = Color.White;
            }

            if(richTextBox1.Text.Length == 0)
            {
                richTextBox1.BackColor = Color.Red;
                ret = false;
            }
            else
            {
                richTextBox1.BackColor = Color.White;
            }

            return ret;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(CheckInputFields())
            {
                // Update the Product:
                Prod.Name = textBoxName.Text;
                Prod.InStock = (int)numericUpDownInStock.Value;
                Prod.Price = (int)numericUpDownPrice.Value;
                Prod.Description = richTextBox1.Text;
                labelMessage.Text = String.Empty;
                Controller.SaveProduct(Prod);  
            }
            else
            {
                labelMessage.Text = "Bitte füllen Sie alle Felder aus!";
            }
        }
    }
}
