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
using System.IO;
using DesktopAppTrouvaille.Controllers;

namespace DesktopAppTrouvaille.Views
{
    public partial class ProductDetailView : UserControl
    {
        public Product Prod;

        private PictureController pictureController = new PictureController();

        OpenFileDialog fileDialog = new OpenFileDialog();

        public ProductController Controller;
        public ProductDetailView()
        {
            InitializeComponent();
        }

        public ProductDetailView(ProductController controller)
        {
            InitializeComponent();
            Controller = controller;
            fileDialog.FileOk += FileSelected;
        }

        public void UpdateView()
        {
            labelProductID.Text = Prod.ProductId.ToString();
            textBoxName.Text = Prod.Name;
            numericUpDownInStock.Value = (int)Prod.InStock;
            numericUpDownPrice.Value = (int)Prod.Price;
            richTextBox1.Text = Prod.Description;
            categoryGridView1.AddCategories(Prod.Categories, Controller.Categories);
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

            if(categoryGridView1.GetCheckedCategories().Count == 0)
            {
                categoryGridView1.BackgroundColor = Color.Red;
            }
            else
            {
                categoryGridView1.BackgroundColor = Color.White;
            }

            return ret;
        }

        protected virtual void buttonSave_Click(object sender, EventArgs e)
        {

            if (CheckInputFields())
            {
                // Update the Product:
                Prod.Name = textBoxName.Text;
                Prod.InStock = (int)numericUpDownInStock.Value;
                Prod.Price = (int)numericUpDownPrice.Value;
                Prod.Description = richTextBox1.Text;
                Prod.Categories = categoryGridView1.GetCheckedCategories();
                labelMessage.Text = String.Empty;

                Controller.SaveProduct(Prod);
            }
            else
            {
                labelMessage.Text = "Bitte füllen Sie alle Felder aus!";
            }
        }

        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonUploadPicture_Click(object sender, EventArgs e)
        { 
            fileDialog.ShowDialog(); 
        }

        private void FileSelected(object sender, EventArgs e)
        {
            Stream fileStream = fileDialog.OpenFile();
            Bitmap img = (Bitmap)Image.FromStream(fileStream);
            pictureController.AddPicture(img);
            pictureBox1.Image = pictureController.GetCurrentPicture();
        }

        // Button Picture Next:
        private void button2_Click(object sender, EventArgs e)
        {
            pictureController.Next();
            pictureBox1.Image = pictureController.GetCurrentPicture();
        }

        private void buttonPicturePrevious_Click(object sender, EventArgs e)
        {
            pictureController.Previous();
            pictureBox1.Image = pictureController.GetCurrentPicture();
            pictureBox1.Refresh();
        }

        private void buttonDeletePicture_Click(object sender, EventArgs e)
        {
            pictureController.RemoveCurrentPicture();
            pictureBox1.Image = pictureController.GetCurrentPicture();
        }
    }
}
