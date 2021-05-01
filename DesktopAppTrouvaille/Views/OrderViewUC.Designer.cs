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
            this.listViewTemplate1 = new DesktopAppTrouvaille.Views.ListViewTemplate();
            this.orderDetailView1 = new DesktopAppTrouvaille.Views.OrderDetailView();
            this.SuspendLayout();
            // 
            // listViewTemplate1
            // 
            this.listViewTemplate1.Location = new System.Drawing.Point(27, 26);
            this.listViewTemplate1.Name = "listViewTemplate1";
            this.listViewTemplate1.Size = new System.Drawing.Size(747, 1057);
            this.listViewTemplate1.TabIndex = 0;
            // 
            // orderDetailView1
            // 
            this.orderDetailView1.Location = new System.Drawing.Point(763, 26);
            this.orderDetailView1.Name = "orderDetailView1";
            this.orderDetailView1.Size = new System.Drawing.Size(1026, 1029);
            this.orderDetailView1.TabIndex = 1;
            // 
            // OrderViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderDetailView1);
            this.Controls.Add(this.listViewTemplate1);
            this.Name = "OrderViewUC";
            this.Size = new System.Drawing.Size(1819, 1116);
            this.ResumeLayout(false);

        }

        #endregion

        private ListViewTemplate listViewTemplate1;
        private OrderDetailView orderDetailView1;
    }
}
