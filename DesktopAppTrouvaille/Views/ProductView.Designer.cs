namespace DesktopAppTrouvaille.Views
{
    partial class ProductView
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
            this.productDetailView1 = new DesktopAppTrouvaille.Views.ProductDetailView();
            this.listViewTemplate1 = new DesktopAppTrouvaille.Views.ListViewTemplate();
            this.SuspendLayout();
            // 
            // productDetailView1
            // 
            this.productDetailView1.BackColor = System.Drawing.SystemColors.Control;
            this.productDetailView1.Location = new System.Drawing.Point(767, 3);
            this.productDetailView1.Name = "productDetailView1";
            this.productDetailView1.Size = new System.Drawing.Size(1771, 1135);
            this.productDetailView1.TabIndex = 1;
            // 
            // listViewTemplate1
            // 
            this.listViewTemplate1.Location = new System.Drawing.Point(3, 3);
            this.listViewTemplate1.Name = "listViewTemplate1";
            this.listViewTemplate1.Size = new System.Drawing.Size(747, 1057);
            this.listViewTemplate1.TabIndex = 0;
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.productDetailView1);
            this.Controls.Add(this.listViewTemplate1);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(1966, 1207);
            this.ResumeLayout(false);

        }

        #endregion

        private ListViewTemplate listViewTemplate1;
        private ProductDetailView productDetailView1;
    }
}
