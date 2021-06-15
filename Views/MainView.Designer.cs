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
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonShowRatings = new System.Windows.Forms.Button();
            this.buttonShowEpmloyees = new System.Windows.Forms.Button();
            this.panelMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowProducts
            // 
            this.buttonShowProducts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShowProducts.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonShowProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.buttonShowOrders.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShowOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.buttonShowCustomers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShowCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowCustomers.Location = new System.Drawing.Point(29, 323);
            this.buttonShowCustomers.Name = "buttonShowCustomers";
            this.buttonShowCustomers.Size = new System.Drawing.Size(489, 114);
            this.buttonShowCustomers.TabIndex = 2;
            this.buttonShowCustomers.Text = "Kunden";
            this.buttonShowCustomers.UseVisualStyleBackColor = false;
            this.buttonShowCustomers.Click += new System.EventHandler(this.buttonShowCustomers_Click);
            // 
            // buttonShowStatistics
            // 
            this.buttonShowStatistics.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShowStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowStatistics.Location = new System.Drawing.Point(29, 747);
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
            this.buttonShowCategories.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShowCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowCategories.Location = new System.Drawing.Point(29, 467);
            this.buttonShowCategories.Name = "buttonShowCategories";
            this.buttonShowCategories.Size = new System.Drawing.Size(489, 111);
            this.buttonShowCategories.TabIndex = 5;
            this.buttonShowCategories.Text = "Kategorien";
            this.buttonShowCategories.UseVisualStyleBackColor = false;
            this.buttonShowCategories.Click += new System.EventHandler(this.buttonShowCategories_Click);
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Controls.Add(this.buttonShowEpmloyees);
            this.panelMainMenu.Controls.Add(this.buttonShowRatings);
            this.panelMainMenu.Controls.Add(this.buttonLogout);
            this.panelMainMenu.Controls.Add(this.buttonShowProducts);
            this.panelMainMenu.Controls.Add(this.buttonShowCategories);
            this.panelMainMenu.Controls.Add(this.buttonShowStatistics);
            this.panelMainMenu.Controls.Add(this.buttonShowOrders);
            this.panelMainMenu.Controls.Add(this.buttonShowCustomers);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(548, 1249);
            this.panelMainMenu.TabIndex = 7;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Location = new System.Drawing.Point(29, 1114);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(489, 104);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Ausloggen";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonShowRatings
            // 
            this.buttonShowRatings.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShowRatings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonShowRatings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowRatings.Location = new System.Drawing.Point(29, 606);
            this.buttonShowRatings.Name = "buttonShowRatings";
            this.buttonShowRatings.Size = new System.Drawing.Size(489, 119);
            this.buttonShowRatings.TabIndex = 7;
            this.buttonShowRatings.Text = "Bewertungen";
            this.buttonShowRatings.UseVisualStyleBackColor = false;
            this.buttonShowRatings.Click += new System.EventHandler(this.buttonShowRatings_Click);
            // 
            // buttonShowEpmloyees
            // 
            this.buttonShowEpmloyees.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShowEpmloyees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowEpmloyees.Location = new System.Drawing.Point(29, 890);
            this.buttonShowEpmloyees.Name = "buttonShowEpmloyees";
            this.buttonShowEpmloyees.Size = new System.Drawing.Size(489, 116);
            this.buttonShowEpmloyees.TabIndex = 8;
            this.buttonShowEpmloyees.Text = "Mitarbeiter";
            this.buttonShowEpmloyees.UseVisualStyleBackColor = false;
            this.buttonShowEpmloyees.Click += new System.EventHandler(this.buttonShowEpmloyees_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelTabView);
            this.Controls.Add(this.panelMainMenu);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(2140, 1249);
            this.panelMainMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonShowEpmloyees;
        private System.Windows.Forms.Button buttonShowRatings;
    }
}
