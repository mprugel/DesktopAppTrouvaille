namespace DesktopAppTrouvaille.UserControls
{
    public partial class MainMenuUC
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
            this.buttonShowProducts = new System.Windows.Forms.Button();
            this.buttonShowOrders = new System.Windows.Forms.Button();
            this.buttonShowCustomers = new System.Windows.Forms.Button();
            this.buttonShowStatistics = new System.Windows.Forms.Button();
            this.panelTabView = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonShowProducts
            // 
            this.buttonShowProducts.Location = new System.Drawing.Point(23, 23);
            this.buttonShowProducts.Name = "buttonShowProducts";
            this.buttonShowProducts.Size = new System.Drawing.Size(489, 109);
            this.buttonShowProducts.TabIndex = 0;
            this.buttonShowProducts.Text = "Produkte";
            this.buttonShowProducts.UseVisualStyleBackColor = true;
            this.buttonShowProducts.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonShowOrders
            // 
            this.buttonShowOrders.Location = new System.Drawing.Point(23, 184);
            this.buttonShowOrders.Name = "buttonShowOrders";
            this.buttonShowOrders.Size = new System.Drawing.Size(489, 113);
            this.buttonShowOrders.TabIndex = 1;
            this.buttonShowOrders.Text = "Bestellungen";
            this.buttonShowOrders.UseVisualStyleBackColor = true;
            // 
            // buttonShowCustomers
            // 
            this.buttonShowCustomers.Location = new System.Drawing.Point(23, 346);
            this.buttonShowCustomers.Name = "buttonShowCustomers";
            this.buttonShowCustomers.Size = new System.Drawing.Size(489, 114);
            this.buttonShowCustomers.TabIndex = 2;
            this.buttonShowCustomers.Text = "Kunden";
            this.buttonShowCustomers.UseVisualStyleBackColor = true;
            // 
            // buttonShowStatistics
            // 
            this.buttonShowStatistics.Location = new System.Drawing.Point(23, 499);
            this.buttonShowStatistics.Name = "buttonShowStatistics";
            this.buttonShowStatistics.Size = new System.Drawing.Size(489, 119);
            this.buttonShowStatistics.TabIndex = 3;
            this.buttonShowStatistics.Text = "Statistiken";
            this.buttonShowStatistics.UseVisualStyleBackColor = true;
            // 
            // panelTabView
            // 
            this.panelTabView.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelTabView.Location = new System.Drawing.Point(562, 23);
            this.panelTabView.Name = "panelTabView";
            this.panelTabView.Size = new System.Drawing.Size(1354, 884);
            this.panelTabView.TabIndex = 4;
            // 
            // MainMenuUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTabView);
            this.Controls.Add(this.buttonShowStatistics);
            this.Controls.Add(this.buttonShowCustomers);
            this.Controls.Add(this.buttonShowOrders);
            this.Controls.Add(this.buttonShowProducts);
            this.Name = "MainMenuUC";
            this.Size = new System.Drawing.Size(1939, 932);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowProducts;
        private System.Windows.Forms.Button buttonShowOrders;
        private System.Windows.Forms.Button buttonShowCustomers;
        private System.Windows.Forms.Button buttonShowStatistics;
        private System.Windows.Forms.Panel panelTabView;
    }
}
