﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;

namespace DesktopAppTrouvaille.Views
{
    public partial class CategoryDetailView : UserControl, IDetailView
    {
        public Category Category;
        public CategoryController Controller { get; set; }
        public string Title { get { return labelTitel.Text; } set { labelTitel.Text = value; } }
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

        public void UpdateView()
        {
            throw new NotImplementedException();
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
            if(CheckInputField())
            {
                SaveClick();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Controller.DeleteCategory(Category);
        }
    }
}
