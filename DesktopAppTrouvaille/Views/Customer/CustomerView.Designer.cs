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
            this.listViewTemplate1 = new DesktopAppTrouvaille.Views.ListViewTemplate();
            this.customerDetail1 = new DesktopAppTrouvaille.Views.CustomerDetail();
            this.SuspendLayout();
            // 
            // listViewTemplate1
            // 
            this.listViewTemplate1.Location = new System.Drawing.Point(0, 0);
            this.listViewTemplate1.Name = "listViewTemplate1";
            this.listViewTemplate1.Size = new System.Drawing.Size(747, 1057);
            this.listViewTemplate1.TabIndex = 0;
            // 
            // customerDetail1
            // 
            this.customerDetail1.Location = new System.Drawing.Point(788, 11);
            this.customerDetail1.Name = "customerDetail1";
            this.customerDetail1.Size = new System.Drawing.Size(948, 1137);
            this.customerDetail1.TabIndex = 1;
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customerDetail1);
            this.Controls.Add(this.listViewTemplate1);
            this.Name = "CustomerView";
            this.Size = new System.Drawing.Size(1960, 1151);
            this.ResumeLayout(false);

        }

        #endregion

        private Views.ListViewTemplate listViewTemplate1;
        private Views.CustomerDetail customerDetail1;
    }
}
