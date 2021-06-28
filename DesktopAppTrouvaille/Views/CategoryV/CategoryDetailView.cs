using System;

using System.Drawing;

using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;

namespace DesktopAppTrouvaille.Views
{
    public partial class CategoryDetailView : DetailViewBase, IDetailView
    {
        public Category Category;
        public CategoryController Controller { get; set; }
        public string Title { get { return labelTitle.Text; } set { labelTitle.Text = value; } }
        public string SaveButtonText { get { return buttonSave.Text; } set { buttonSave.Text = value; } }

        private bool _displaySaveButton = true;
        public bool DisplayDeleteButton
        {
            get { return _displaySaveButton; }
            set
            {
                _displaySaveButton = value;
                buttonDelete.Visible = value;
            }
        }

        public CategoryDetailView(CategoryController controller = null)
        {
            Controller = controller;
            InitializeComponent();
        }

        public override void UpdateView()
        {
            base.UpdateView();

            Category = Controller.GetDetailCategory();
            textBoxName.Text = Category.Name;
        }

        public void SetModel(IModel model)
        {
            Category = (Category)model;
            textBoxName.Text = Category.Name;
        }

        public void SetController(IController controller)
        {
            Controller = (CategoryController)controller;
        }
        private bool CheckInputField()
        {
            textBoxName.BackColor = Color.White;

            if (textBoxName.Text.Length == 0)
            {
                textBoxName.BackColor = Color.FromArgb(120,0,0);
                return false;
            }
            return true;
        }
        protected Category GetCategoryFromInputFields()
        {
            Category category = new Category(Category);
            category.Name = textBoxName.Text;
            return category;
        }
        protected virtual void SaveClick()
        {
            Controller.UpdateCategory(GetCategoryFromInputFields());
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(System.Windows.Forms.ValidationConstraints.Enabled))
            {
                Enabled = false;
                SaveClick(); 
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Controller.DeleteCategory(Category);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                e.Cancel = true;
                textBoxName.Focus();
                errorProvider1.SetError(textBoxName, "Feld darf nicht leer sein!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxName, "");
            }
        }
    }
}
