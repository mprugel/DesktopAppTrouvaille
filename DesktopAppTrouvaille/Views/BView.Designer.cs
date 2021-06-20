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
        protected void InitializeComponent()
        {
            this.panelDetailView = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.listView = new DesktopAppTrouvaille.Views.ListViewTemplate();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelDetailView
            // 
            this.panelDetailView.AutoSize = true;
            this.panelDetailView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelDetailView.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDetailView.Location = new System.Drawing.Point(439, 0);
            this.panelDetailView.Margin = new System.Windows.Forms.Padding(50, 2, 2, 2);
            this.panelDetailView.Name = "panelDetailView";
            this.panelDetailView.Size = new System.Drawing.Size(0, 639);
            this.panelDetailView.TabIndex = 1;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.White;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Black;
            this.labelStatus.Location = new System.Drawing.Point(11, 615);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(43, 13);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Online";
            // 
            // listView
            // 
            this.listView.AddButtonText = "Neues Produkt";
            this.listView.AutoSize = true;
            this.listView.BackColor = System.Drawing.Color.White;
            this.listView.DisplayAddButton = true;
            this.listView.DisplayFilterView = true;
            this.listView.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView.FilterView = null;
            this.listView.ForeColor = System.Drawing.Color.Black;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Margin = new System.Windows.Forms.Padding(0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(377, 639);
            this.listView.TabIndex = 0;
            this.listView.Title = "Produkte";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(377, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 639);
            this.panel1.TabIndex = 3;
            // 
            // BView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.panelDetailView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BView";
            this.Size = new System.Drawing.Size(1138, 639);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected ListViewTemplate listView;
        protected System.Windows.Forms.Panel panelDetailView;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panel1;
    }
}
