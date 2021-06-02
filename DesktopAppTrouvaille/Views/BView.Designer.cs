namespace DesktopAppTrouvaille.Views
{
    public partial class BView
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
            this.listView = new DesktopAppTrouvaille.Views.ListViewTemplate();
            this.SuspendLayout();
            // 
            // panelDetailView
            // 
            this.panelDetailView.AutoSize = true;
            this.panelDetailView.BackColor = System.Drawing.Color.White;
            this.panelDetailView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDetailView.Location = new System.Drawing.Point(770, 0);
            this.panelDetailView.Name = "panelDetailView";
            this.panelDetailView.Size = new System.Drawing.Size(1507, 0);
            this.panelDetailView.TabIndex = 1;
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
            // listViewTemplate1
            // 
            this.listView.AddButtonText = "Neues Produkt";
            this.listView.AutoSize = true;
            this.listView.BackColor = System.Drawing.Color.White;
            this.listView.DisplayAddButton = true;
            this.listView.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView.ForeColor = System.Drawing.Color.Black;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listViewTemplate1";
            this.listView.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.listView.Size = new System.Drawing.Size(770, 1309);
            this.listView.TabIndex = 0;
            this.listView.Title = "Produkte";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.panelDetailView);
            this.Controls.Add(this.listView);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(2277, 1309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected ListViewTemplate listView;
        protected System.Windows.Forms.Panel panelDetailView;
        private System.Windows.Forms.Label labelStatus;
    }
}
