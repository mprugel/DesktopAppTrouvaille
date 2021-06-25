using DesktopAppTrouvaille.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Views.CategoryV
{
    public class NewCategoryView : CategoryDetailView
    {
        public NewCategoryView(CategoryController controller = null) : base(controller)
        {
            Category = new Models.Category();
            InitializeComponent();
            Enabled = true;
        }

        protected override void SaveClick()
        {
            Controller.SaveNewCategory(GetCategoryFromInputFields());
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // NewCategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.DisplayDeleteButton = false;
            this.Name = "NewCategoryView";
            this.SaveButtonText = "Neue Kategorie anlegen";
            this.Title = "Neue Kategorie anlegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
