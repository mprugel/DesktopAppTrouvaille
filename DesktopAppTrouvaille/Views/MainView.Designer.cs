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
            this.buttonShowEpmloyees = new System.Windows.Forms.Button();
            this.buttonShowRatings = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panelMainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowProducts
            // 
            this.buttonShowProducts.BackColor = System.Drawing.Color.DimGray;
            this.buttonShowProducts.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonShowProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowProducts.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowProducts.ForeColor = System.Drawing.Color.White;
            this.buttonShowProducts.Location = new System.Drawing.Point(14, 40);
            this.buttonShowProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.buttonShowProducts.Name = "buttonShowProducts";
            this.buttonShowProducts.Size = new System.Drawing.Size(244, 54);
            this.buttonShowProducts.TabIndex = 0;
            this.buttonShowProducts.Text = "Produkte";
            this.buttonShowProducts.UseVisualStyleBackColor = false;
            this.buttonShowProducts.Click += new System.EventHandler(this.button1_Click);
            this.buttonShowProducts.Leave += new System.EventHandler(this.buttonShowProducts_Leave);
            // 
            // buttonShowOrders
            // 
            this.buttonShowOrders.BackColor = System.Drawing.Color.DimGray;
            this.buttonShowOrders.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonShowOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowOrders.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowOrders.ForeColor = System.Drawing.Color.White;
            this.buttonShowOrders.Location = new System.Drawing.Point(14, 106);
            this.buttonShowOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.buttonShowOrders.Name = "buttonShowOrders";
            this.buttonShowOrders.Size = new System.Drawing.Size(244, 56);
            this.buttonShowOrders.TabIndex = 1;
            this.buttonShowOrders.Text = "Bestellungen";
            this.buttonShowOrders.UseVisualStyleBackColor = false;
            this.buttonShowOrders.Click += new System.EventHandler(this.buttonShowOrders_Click);
            this.buttonShowOrders.Leave += new System.EventHandler(this.buttonShowProducts_Leave);
            // 
            // buttonShowCustomers
            // 
            this.buttonShowCustomers.BackColor = System.Drawing.Color.DimGray;
            this.buttonShowCustomers.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonShowCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowCustomers.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowCustomers.ForeColor = System.Drawing.Color.White;
            this.buttonShowCustomers.Location = new System.Drawing.Point(14, 174);
            this.buttonShowCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.buttonShowCustomers.Name = "buttonShowCustomers";
            this.buttonShowCustomers.Size = new System.Drawing.Size(244, 57);
            this.buttonShowCustomers.TabIndex = 2;
            this.buttonShowCustomers.Text = "Kunden";
            this.buttonShowCustomers.UseVisualStyleBackColor = false;
            this.buttonShowCustomers.Click += new System.EventHandler(this.buttonShowCustomers_Click);
            this.buttonShowCustomers.Leave += new System.EventHandler(this.buttonShowProducts_Leave);
            // 
            // buttonShowStatistics
            // 
            this.buttonShowStatistics.BackColor = System.Drawing.Color.DimGray;
            this.buttonShowStatistics.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonShowStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowStatistics.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowStatistics.ForeColor = System.Drawing.Color.White;
            this.buttonShowStatistics.Location = new System.Drawing.Point(14, 453);
            this.buttonShowStatistics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.buttonShowStatistics.Name = "buttonShowStatistics";
            this.buttonShowStatistics.Size = new System.Drawing.Size(244, 60);
            this.buttonShowStatistics.TabIndex = 3;
            this.buttonShowStatistics.Text = "Statistiken";
            this.buttonShowStatistics.UseVisualStyleBackColor = false;
            this.buttonShowStatistics.Visible = false;
            this.buttonShowStatistics.Leave += new System.EventHandler(this.buttonShowProducts_Leave);
            // 
            // panelTabView
            // 
            this.panelTabView.AutoSize = true;
            this.panelTabView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTabView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTabView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelTabView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabView.Location = new System.Drawing.Point(280, 42);
            this.panelTabView.Margin = new System.Windows.Forms.Padding(0);
            this.panelTabView.Name = "panelTabView";
            this.panelTabView.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.panelTabView.Size = new System.Drawing.Size(802, 641);
            this.panelTabView.TabIndex = 4;
            // 
            // buttonShowCategories
            // 
            this.buttonShowCategories.BackColor = System.Drawing.Color.DimGray;
            this.buttonShowCategories.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonShowCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowCategories.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowCategories.ForeColor = System.Drawing.Color.White;
            this.buttonShowCategories.Location = new System.Drawing.Point(14, 243);
            this.buttonShowCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.buttonShowCategories.Name = "buttonShowCategories";
            this.buttonShowCategories.Size = new System.Drawing.Size(244, 56);
            this.buttonShowCategories.TabIndex = 5;
            this.buttonShowCategories.Text = "Kategorien";
            this.buttonShowCategories.UseVisualStyleBackColor = false;
            this.buttonShowCategories.Click += new System.EventHandler(this.buttonShowCategories_Click);
            this.buttonShowCategories.Leave += new System.EventHandler(this.buttonShowProducts_Leave);
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.AutoSize = true;
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMainMenu.Controls.Add(this.buttonShowEpmloyees);
            this.panelMainMenu.Controls.Add(this.buttonShowRatings);
            this.panelMainMenu.Controls.Add(this.buttonLogout);
            this.panelMainMenu.Controls.Add(this.buttonShowProducts);
            this.panelMainMenu.Controls.Add(this.buttonShowCategories);
            this.panelMainMenu.Controls.Add(this.buttonShowStatistics);
            this.panelMainMenu.Controls.Add(this.buttonShowOrders);
            this.panelMainMenu.Controls.Add(this.buttonShowCustomers);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 42);
            this.panelMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panelMainMenu.Size = new System.Drawing.Size(280, 641);
            this.panelMainMenu.TabIndex = 7;
            // 
            // buttonShowEpmloyees
            // 
            this.buttonShowEpmloyees.BackColor = System.Drawing.Color.DimGray;
            this.buttonShowEpmloyees.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonShowEpmloyees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowEpmloyees.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowEpmloyees.ForeColor = System.Drawing.Color.White;
            this.buttonShowEpmloyees.Location = new System.Drawing.Point(14, 311);
            this.buttonShowEpmloyees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.buttonShowEpmloyees.Name = "buttonShowEpmloyees";
            this.buttonShowEpmloyees.Size = new System.Drawing.Size(244, 58);
            this.buttonShowEpmloyees.TabIndex = 8;
            this.buttonShowEpmloyees.Text = "Mitarbeiter";
            this.buttonShowEpmloyees.UseVisualStyleBackColor = false;
            this.buttonShowEpmloyees.Click += new System.EventHandler(this.buttonShowEpmloyees_Click);
            this.buttonShowEpmloyees.Leave += new System.EventHandler(this.buttonShowProducts_Leave);
            // 
            // buttonShowRatings
            // 
            this.buttonShowRatings.BackColor = System.Drawing.Color.DimGray;
            this.buttonShowRatings.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonShowRatings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowRatings.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowRatings.ForeColor = System.Drawing.Color.White;
            this.buttonShowRatings.Location = new System.Drawing.Point(14, 381);
            this.buttonShowRatings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.buttonShowRatings.Name = "buttonShowRatings";
            this.buttonShowRatings.Size = new System.Drawing.Size(244, 60);
            this.buttonShowRatings.TabIndex = 7;
            this.buttonShowRatings.Text = "Bewertungen";
            this.buttonShowRatings.UseVisualStyleBackColor = false;
            this.buttonShowRatings.Visible = false;
            this.buttonShowRatings.Click += new System.EventHandler(this.buttonShowRatings_Click);
            this.buttonShowRatings.Leave += new System.EventHandler(this.buttonShowProducts_Leave);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLogout.BackColor = System.Drawing.Color.DimGray;
            this.buttonLogout.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(14, 578);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(244, 52);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Ausloggen";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 42);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(270, 11);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 20);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Status";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panelTabView);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(1082, 683);
            this.panelMainMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStatus;
    }
}
