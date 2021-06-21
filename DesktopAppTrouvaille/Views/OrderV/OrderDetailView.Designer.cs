namespace DesktopAppTrouvaille.Views
{
    partial class OrderDetailView
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
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.comboBoxOrderState = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonToProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.adressViewOrder = new DesktopAppTrouvaille.Views.AdressView();
            this.adressViewDelivery = new DesktopAppTrouvaille.Views.AdressView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Size = new System.Drawing.Size(222, 26);
            this.labelTitle.Text = "Bestellung bearbeiten";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(510, 12);
            this.buttonSave.Size = new System.Drawing.Size(226, 29);
            this.buttonSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Location = new System.Drawing.Point(473, 241);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelOrderDate.Size = new System.Drawing.Size(61, 13);
            this.labelOrderDate.TabIndex = 3;
            this.labelOrderDate.Text = "21.08.2020";
            this.labelOrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelOrderDate.Click += new System.EventHandler(this.labelOrderDate_Click);
            // 
            // comboBoxOrderState
            // 
            this.comboBoxOrderState.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxOrderState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxOrderState.FormattingEnabled = true;
            this.comboBoxOrderState.Items.AddRange(new object[] {
            "Status"});
            this.comboBoxOrderState.Location = new System.Drawing.Point(124, 238);
            this.comboBoxOrderState.Name = "comboBoxOrderState";
            this.comboBoxOrderState.Size = new System.Drawing.Size(152, 21);
            this.comboBoxOrderState.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 269);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artikel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price,
            this.count,
            this.buttonToProduct});
            this.dataGridView1.Location = new System.Drawing.Point(16, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(611, 225);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 10;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Einzelpreis";
            this.price.MinimumWidth = 10;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // count
            // 
            this.count.HeaderText = "Menge";
            this.count.MinimumWidth = 10;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // buttonToProduct
            // 
            this.buttonToProduct.HeaderText = "Zum Produkt";
            this.buttonToProduct.MinimumWidth = 10;
            this.buttonToProduct.Name = "buttonToProduct";
            this.buttonToProduct.ReadOnly = true;
            this.buttonToProduct.Text = ">";
            this.buttonToProduct.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 576);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Summe";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSum.Location = new System.Drawing.Point(636, 576);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(21, 13);
            this.labelSum.TabIndex = 19;
            this.labelSum.Text = "0€";
            this.labelSum.Click += new System.EventHandler(this.labelSum_Click);
            // 
            // adressViewOrder
            // 
            this.adressViewOrder.Editable = false;
            this.adressViewOrder.Location = new System.Drawing.Point(376, 70);
            this.adressViewOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adressViewOrder.Name = "adressViewOrder";
            this.adressViewOrder.Size = new System.Drawing.Size(281, 140);
            this.adressViewOrder.TabIndex = 16;
            this.adressViewOrder.Title = "Rechnungsadresse";
            // 
            // adressViewDelivery
            // 
            this.adressViewDelivery.Editable = false;
            this.adressViewDelivery.Location = new System.Drawing.Point(16, 70);
            this.adressViewDelivery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adressViewDelivery.Name = "adressViewDelivery";
            this.adressViewDelivery.Size = new System.Drawing.Size(260, 140);
            this.adressViewDelivery.TabIndex = 15;
            this.adressViewDelivery.Title = "Lieferadresse";
            this.adressViewDelivery.Load += new System.EventHandler(this.adressViewDelivery_Load);
            // 
            // OrderDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adressViewOrder);
            this.Controls.Add(this.adressViewDelivery);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxOrderState);
            this.Controls.Add(this.labelOrderDate);
            this.Name = "OrderDetailView";
            this.Size = new System.Drawing.Size(750, 703);
            this.Controls.SetChildIndex(this.labelOrderDate, 0);
            this.Controls.SetChildIndex(this.comboBoxOrderState, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.adressViewDelivery, 0);
            this.Controls.SetChildIndex(this.adressViewOrder, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.labelSum, 0);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.ComboBox comboBoxOrderState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private AdressView adressViewDelivery;
        private AdressView adressViewOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewButtonColumn buttonToProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSum;
    }
}
