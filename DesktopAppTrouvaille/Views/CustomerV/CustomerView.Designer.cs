namespace DesktopAppTrouvaille.Views
{
    partial class CustomerView
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
            this.listView.DisplayAddButton = false;
            this.listView.Size = new System.Drawing.Size(427, 683);
            this.listView.Title = "Kunden";
            // 
            // panelDetailView
            // 
            this.panelDetailView.Size = new System.Drawing.Size(0, 683);
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "CustomerView";
            this.Size = new System.Drawing.Size(1960, 683);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
