using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Views.CategoryV
{
    public class NewCategoryView : CategoryDetailView
    {
        public NewCategoryView()
        {
            InitializeComponent();
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
