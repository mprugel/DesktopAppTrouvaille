namespace DesktopAppTrouvaille.Views
{
    partial class CategoryView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.AddButtonText = "Neue Kategorie";
            this.listView.DisplayFilterView = false;
            this.listView.Size = new System.Drawing.Size(388, 1248);
            this.listView.Title = "Kategorien";
            // 
            // panelDetailView
            // 
            this.panelDetailView.Size = new System.Drawing.Size(1466, 0);
            // 
            // CategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CategoryView";
            this.Size = new System.Drawing.Size(1854, 1248);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
