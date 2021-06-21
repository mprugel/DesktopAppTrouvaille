namespace DesktopAppTrouvaille.Views
{
    partial class OrderViewUC
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
            this.listView.Size = new System.Drawing.Size(377, 637);
            this.listView.Title = "Bestellungen";
            // 
            // panelDetailView
            // 
            this.panelDetailView.Size = new System.Drawing.Size(0, 637);
            // 
            // OrderViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "OrderViewUC";
            this.Size = new System.Drawing.Size(1819, 637);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
