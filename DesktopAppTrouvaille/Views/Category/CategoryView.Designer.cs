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
            this.listViewTemplate1 = new DesktopAppTrouvaille.Views.ListViewTemplate();
            this.SuspendLayout();
            // 
            // listViewTemplate1
            // 
            this.listViewTemplate1.AddButtonText = "Neue Kategorie";
            this.listViewTemplate1.AutoSize = true;
            this.listViewTemplate1.BackColor = System.Drawing.Color.White;
            this.listViewTemplate1.DisplayAddButton = true;
            this.listViewTemplate1.Location = new System.Drawing.Point(22, 33);
            this.listViewTemplate1.Name = "listViewTemplate1";
            this.listViewTemplate1.Size = new System.Drawing.Size(747, 1057);
            this.listViewTemplate1.TabIndex = 0;
            this.listViewTemplate1.Title = "Kategorien";
            // 
            // CategoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewTemplate1);
            this.Name = "CategoryView";
            this.Size = new System.Drawing.Size(1854, 1148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListViewTemplate listViewTemplate1;
    }
}
