using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DesktopAppTrouvaille.Models;
using System.IO;
using DesktopAppTrouvaille.Controllers;

namespace DesktopAppTrouvaille.Views
{
    public partial class ProductDetailView : UserControl, IDetailView
    {
        private Color _emptyFieldColor = Color.FromArgb(255,168,168);
        public Product Prod;

        //Only needed for testing:
        List<Picture> picList = new List<Picture>();

        private PictureController pictureController = new PictureController();

        private OpenFileDialog fileDialog = new OpenFileDialog();

        public ProductController Controller;
        public ProductDetailView()
        {
            InitializeComponent();
        }

        public ProductDetailView(ProductController controller)
        {
            InitializeComponent();
            Controller = controller;

            // Set Eventhandler for Selecting Images:
            fileDialog.FileOk += FileSelected;
        }

        public void UpdateView()
        {
            Prod = Controller.DetailProduct;
            // Update the View Elemts with with the Product Data:
            labelProductID.Text = Prod.ProductId.ToString();
            textBoxName.Text = Prod.Name;
            numericUpDownInStock.Value = (int)Prod.InStock;
            numericUpDownMinStock.Value = Prod.MinStock;
            numericUpDownTax.Value = (int)Prod.Tax;
            numericUpDownPrice.Value = (int)Prod.Price;
            richTextBox1.Text = Prod.Description;
            categorySelection1.AddCategories(Prod.ProductCategories, Controller.Categories);
            
            // Display the Picture in the Picture Box:
            picList.Add(Prod.Picture);
            pictureController.SetPictures(picList);
            pictureBox1.Image = pictureController.GetCurrentPicture().ToBitmap();
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

        // Check the input fields on the GUI:
        public bool CheckInputFields()
        {
            bool ret = true;
            if(textBoxName.Text.Length == 0)
            {
                textBoxName.BackColor = _emptyFieldColor;
                ret = false;
            }
            else
            {
                textBoxName.BackColor = Color.White;
            }

            if(numericUpDownPrice.Value <= 0)
            {
                numericUpDownPrice.BackColor = _emptyFieldColor;
                ret = false;
            }
            else
            {
                numericUpDownPrice.BackColor = Color.White;
            }

            if(richTextBox1.Text.Length == 0)
            {
                richTextBox1.BackColor = _emptyFieldColor;
                ret = false;
            }
            else
            {
                richTextBox1.BackColor = Color.White;
            }

            /*if(categoryGridView1.GetCheckedCategories().Count == 0)
            {
                categoryGridView1.BackgroundColor = _emptyFieldColor;
            }
            else
            {
                categoryGridView1.BackgroundColor = Color.White;
            }*/

            if(ret)
            {
                labelMessage.Text = String.Empty;
            }
            else
            {
                labelMessage.Text = "Bitte füllen Sie alle Felder aus!";
            }

            return ret;
        }

        public Product GetProductFromInputs()
        {
            // Create new Product from the Data in the GUI, but keep ProductID:
            Product p = new Product();
            p.ProductId = Prod.ProductId;
            p.Name = textBoxName.Text;
            p.InStock = (int)numericUpDownInStock.Value;
            p.MinStock = (int)numericUpDownMinStock.Value;
            p.Tax = numericUpDownTax.Value;
            p.Price = (int)numericUpDownPrice.Value;
            p.Description = richTextBox1.Text;
            p.ProductCategories = categorySelection1.GetCheckedCategories();
            p.Picture = pictureController.GetCurrentPicture();

            return p;
        }
        protected virtual void buttonSave_Click(object sender, EventArgs e)
        {
            // Check if all Form Fields are filled by the User:
            if (CheckInputFields())
            {
                // Update the Product:
                Controller.UpdateProduct(Prod, GetProductFromInputs());
            }
        }

        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonUploadPicture_Click(object sender, EventArgs e)
        { 
            fileDialog.ShowDialog(); 
        }

        // Called wehen User selects File in filechooser
        private void FileSelected(object sender, EventArgs e)
        {
            Stream fileStream = fileDialog.OpenFile();
            Bitmap img = (Bitmap)Image.FromStream(fileStream);
            Picture pic = new Picture();
            pic.SetImageData(img);
            pictureController.AddPicture(pic);
            pictureBox1.Image = pictureController.GetCurrentPicture().ToBitmap();
        }

        // Button Picture Next:
        private void button2_Click(object sender, EventArgs e)
        {
            pictureController.Next();
            pictureBox1.Image = pictureController.GetCurrentPicture().ToBitmap();
        }

        private void buttonPicturePrevious_Click(object sender, EventArgs e)
        {
            pictureController.Previous();
            pictureBox1.Image = pictureController.GetCurrentPicture().ToBitmap();
            pictureBox1.Refresh();
        }

        private void buttonDeletePicture_Click(object sender, EventArgs e)
        {
            pictureController.RemoveCurrentPicture();
            pictureBox1.Image = pictureController.GetCurrentPicture().ToBitmap();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Controller.DeleteProduct(Prod);
        }

        public void SetModel(IModel model)
        {
            Prod = (Product)model;
        }

        public void SetController(IController controller)
        {
            Controller = (ProductController)controller;
        }
    }
}
