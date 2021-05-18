namespace DesktopAppTrouvaille.Views
{
    public partial class MainView
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
            this.buttonShowCategories = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowProducts
            // 
            this.buttonShowProducts.BackColor = System.Drawing.Color.White;
            this.buttonShowProducts.Location = new System.Drawing.Point(29, 23);
            this.buttonShowProducts.Name = "buttonShowProducts";
            this.buttonShowProducts.Size = new System.Drawing.Size(489, 109);
            this.buttonShowProducts.TabIndex = 0;
            this.buttonShowProducts.Text = "Produkte";
            this.buttonShowProducts.UseVisualStyleBackColor = false;
            this.buttonShowProducts.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonShowOrders
            // 
            this.buttonShowOrders.BackColor = System.Drawing.Color.White;
            this.buttonShowOrders.Location = new System.Drawing.Point(29, 184);
            this.buttonShowOrders.Name = "buttonShowOrders";
            this.buttonShowOrders.Size = new System.Drawing.Size(489, 113);
            this.buttonShowOrders.TabIndex = 1;
            this.buttonShowOrders.Text = "Bestellungen";
            this.buttonShowOrders.UseVisualStyleBackColor = false;
            this.buttonShowOrders.Click += new System.EventHandler(this.buttonShowOrders_Click);
            // 
            // buttonShowCustomers
            // 
            this.buttonShowCustomers.BackColor = System.Drawing.Color.White;
            this.buttonShowCustomers.Location = new System.Drawing.Point(29, 346);
            this.buttonShowCustomers.Name = "buttonShowCustomers";
            this.buttonShowCustomers.Size = new System.Drawing.Size(489, 114);
            this.buttonShowCustomers.TabIndex = 2;
            this.buttonShowCustomers.Text = "Kunden";
            this.buttonShowCustomers.UseVisualStyleBackColor = false;
            this.buttonShowCustomers.Click += new System.EventHandler(this.buttonShowCustomers_Click);
            // 
            // buttonShowStatistics
            // 
            this.buttonShowStatistics.BackColor = System.Drawing.Color.White;
            this.buttonShowStatistics.Location = new System.Drawing.Point(29, 510);
            this.buttonShowStatistics.Name = "buttonShowStatistics";
            this.buttonShowStatistics.Size = new System.Drawing.Size(489, 119);
            this.buttonShowStatistics.TabIndex = 3;
            this.buttonShowStatistics.Text = "Statistiken";
            this.buttonShowStatistics.UseVisualStyleBackColor = false;
            // 
            // panelTabView
            // 
            this.panelTabView.AutoSize = true;
            this.panelTabView.BackColor = System.Drawing.Color.White;
            this.panelTabView.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTabView.Location = new System.Drawing.Point(548, 0);
            this.panelTabView.Name = "panelTabView";
            this.panelTabView.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panelTabView.Size = new System.Drawing.Size(20, 1249);
            this.panelTabView.TabIndex = 4;
            // 
            // buttonShowCategories
            // 
            this.buttonShowCategories.BackColor = System.Drawing.Color.White;
            this.buttonShowCategories.Location = new System.Drawing.Point(29, 682);
            this.buttonShowCategories.Name = "buttonShowCategories";
            this.buttonShowCategories.Size = new System.Drawing.Size(489, 111);
            this.buttonShowCategories.TabIndex = 5;
            this.buttonShowCategories.Text = "Kategorien";
            this.buttonShowCategories.UseVisualStyleBackColor = false;
            this.buttonShowCategories.Click += new System.EventHandler(this.buttonShowCategories_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonShowProducts);
            this.panel1.Controls.Add(this.buttonShowCategories);
            this.panel1.Controls.Add(this.buttonShowStatistics);
            this.panel1.Controls.Add(this.buttonShowOrders);
            this.panel1.Controls.Add(this.buttonShowCustomers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 1249);
            this.panel1.TabIndex = 7;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelTabView);
            this.Controls.Add(this.panel1);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(2140, 1249);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowProducts;
        private System.Windows.Forms.Button buttonShowOrders;
        private System.Windows.Forms.Button buttonShowCustomers;
        private System.Windows.Forms.Button buttonShowStatistics;
        private System.Windows.Forms.Panel panelTabView;
        private System.Windows.Forms.Button buttonShowCategories;
        private System.Windows.Forms.Panel panel1;
    }
}
