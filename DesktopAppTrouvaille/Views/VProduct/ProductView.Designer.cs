namespace DesktopAppTrouvaille.Views.VProduct
{
    public partial class ProductView
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelDetailView
            // 
            this.panelDetailView.Size = new System.Drawing.Size(1119, 1256);
            // 
            // listViewTemplate1
            // 
            this.listViewTemplate1.AddButtonText = "Neues Produkt";
            this.listViewTemplate1.Title = "Produkte";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.White;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Black;
            this.labelStatus.Location = new System.Drawing.Point(24, 1223);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(80, 25);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Online";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelStatus);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(2277, 1309);
            this.Controls.SetChildIndex(this.panelDetailView, 0);
            this.Controls.SetChildIndex(this.listViewTemplate1, 0);
            this.Controls.SetChildIndex(this.labelStatus, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelStatus;
    }
}
