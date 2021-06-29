using DesktopAppTrouvaille.FilterCriterias;
using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DesktopAppTrouvaille.Views.FilterV
{
    public class ProductFilter : Filter, IView
    {
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownTo;
        private System.Windows.Forms.NumericUpDown numericUpDownFrom;
        private CheckBox checkBoxOnlyActive;
        private System.ComponentModel.IContainer components;
        private ProductController _controller;


        private ProductFilterCriteria _filter;

        private Category _selectedCategory;
        public ProductFilterCriteria GetFilterCriteria()
        {
            List<Guid> categories = new List<Guid>();
            Category cat = (Category)comboBoxCategory.SelectedItem;
            if(comboBoxCategory.SelectedIndex == 0) 
            {
                _selectedCategory = null;
            }
            else
            {
                _selectedCategory = cat;
                categories.Add(cat.GetGuid());
            }
            _filter = new ProductFilterCriteria((int)numericUpDownFrom.Value, (int)numericUpDownTo.Value, categories, checkBoxOnlyActive.Checked);
            return _filter;
        }

        public override void SendFilterToController()
        {
              _controller.SetFilter(GetFilterCriteria());
        }

        public ProductFilter(ProductController controller)
        {
            InitializeComponent();
            _controller = controller;
        }
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownTo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFrom = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxOnlyActive = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(240, 13);
            this.checkBox1.Size = new System.Drawing.Size(77, 17);
            this.checkBox1.Text = "Anwenden";
            this.checkBox1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownTo);
            this.groupBox1.Controls.Add(this.numericUpDownFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(224, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lagerbestand";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numericUpDownTo
            // 
            this.numericUpDownTo.Location = new System.Drawing.Point(130, 24);
            this.numericUpDownTo.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownTo.Name = "numericUpDownTo";
            this.numericUpDownTo.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownTo.TabIndex = 6;
            // 
            // numericUpDownFrom
            // 
            this.numericUpDownFrom.Location = new System.Drawing.Point(31, 25);
            this.numericUpDownFrom.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownFrom.Name = "numericUpDownFrom";
            this.numericUpDownFrom.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownFrom.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "bis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "von";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Alle"});
            this.comboBoxCategory.Location = new System.Drawing.Point(67, 11);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(159, 21);
            this.comboBoxCategory.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategorie";
            // 
            // checkBoxOnlyActive
            // 
            this.checkBoxOnlyActive.AutoSize = true;
            this.checkBoxOnlyActive.Location = new System.Drawing.Point(14, 58);
            this.checkBoxOnlyActive.Name = "checkBoxOnlyActive";
            this.checkBoxOnlyActive.Size = new System.Drawing.Size(121, 17);
            this.checkBoxOnlyActive.TabIndex = 7;
            this.checkBoxOnlyActive.Text = "Nur aktive Produkte";
            this.checkBoxOnlyActive.UseVisualStyleBackColor = true;
            // 
            // ProductFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkBoxOnlyActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ProductFilter";
            this.Size = new System.Drawing.Size(320, 138);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.comboBoxCategory, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.checkBoxOnlyActive, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void UpdateView()
        {
            Category first = new Category();
            first.Name = "-- Alle --";
            List<Category> categories = new List<Category>(_controller.Categories);
            categories.Insert(0, first);
            comboBoxCategory.DataSource = categories;
            comboBoxCategory.DisplayMember = "Name";
            comboBoxCategory.ValueMember = "Name";

            if(_selectedCategory != null)
            {
                comboBoxCategory.SelectedItem = _selectedCategory;
            }
            
           
        }
    }
}
