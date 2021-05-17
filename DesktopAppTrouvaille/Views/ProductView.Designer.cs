namespace DesktopAppTrouvaille.Views
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
            this.panelDetailView = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.listViewTemplate1 = new DesktopAppTrouvaille.Views.ListViewTemplate();
            this.SuspendLayout();
            // 
            // panelDetailView
            // 
            this.panelDetailView.Location = new System.Drawing.Point(756, 3);
            this.panelDetailView.Name = "panelDetailView";
            this.panelDetailView.Size = new System.Drawing.Size(1099, 1167);
            this.panelDetailView.TabIndex = 1;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(26, 19);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(74, 25);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Online";
            // 
            // listViewTemplate1
            // 
            this.listViewTemplate1.Location = new System.Drawing.Point(3, 69);
            this.listViewTemplate1.Name = "listViewTemplate1";
            this.listViewTemplate1.Size = new System.Drawing.Size(747, 1057);
            this.listViewTemplate1.TabIndex = 0;
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.panelDetailView);
            this.Controls.Add(this.listViewTemplate1);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(1966, 1207);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListViewTemplate listViewTemplate1;
        private System.Windows.Forms.Panel panelDetailView;
        private System.Windows.Forms.Label labelStatus;
    }
}
