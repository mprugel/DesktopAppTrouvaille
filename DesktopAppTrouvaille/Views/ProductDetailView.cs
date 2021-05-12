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
        public Product Prod 
        { get { return _prod; }
            set
            {
                _prod = value;
                labelTitle.Text = "Produkt bearbeiten";
                buttonDelete.Visible = true;
                buttonSave.Text = "Änderungen speichern";
                newProduct = false;
            } 
        }

        public ProductController Controller;
        public ProductDetailView()
        {
            InitializeComponent();
        }

        public void NewProduct()
        {
            Prod = new Product();
            labelTitle.Text = "Neues Produkt anlegen";
            buttonDelete.Visible = false;
            buttonSave.Text = "Produkt anlegen";
            newProduct = true;
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
            bool ret = false;
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
                Controller.ClickSave(Prod);
            }
            else
            {
                labelMessage.Text = "Bitte füllen Sie alle Felder aus!";
            }
        }
    }
}
