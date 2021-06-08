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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adressViewOrder = new DesktopAppTrouvaille.Views.AdressView();
            this.adressViewDelivery = new DesktopAppTrouvaille.Views.AdressView();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Location = new System.Drawing.Point(625, 406);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelOrderDate.Size = new System.Drawing.Size(120, 25);
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
            this.comboBoxOrderState.Location = new System.Drawing.Point(175, 403);
            this.comboBoxOrderState.Name = "comboBoxOrderState";
            this.comboBoxOrderState.Size = new System.Drawing.Size(292, 33);
            this.comboBoxOrderState.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(859, 285);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(63, 918);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "Stornieren";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(676, 918);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 61);
            this.button2.TabIndex = 9;
            this.button2.Text = "Änderungen speichern";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(58, 516);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(903, 378);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artikel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bestellung bearbeiten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(513, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Datum";
            // 
            // adressViewOrder
            // 
            this.adressViewOrder.Location = new System.Drawing.Point(513, 107);
            this.adressViewOrder.Name = "adressViewOrder";
            this.adressViewOrder.Size = new System.Drawing.Size(440, 255);
            this.adressViewOrder.TabIndex = 16;
            this.adressViewOrder.Title = "Rechnungsadresse";
            // 
            // adressViewDelivery
            // 
            this.adressViewDelivery.Location = new System.Drawing.Point(63, 107);
            this.adressViewDelivery.Name = "adressViewDelivery";
            this.adressViewDelivery.Size = new System.Drawing.Size(404, 255);
            this.adressViewDelivery.TabIndex = 15;
            this.adressViewDelivery.Title = "Lieferadresse";
            this.adressViewDelivery.Load += new System.EventHandler(this.adressViewDelivery_Load);
            // 
            // OrderDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adressViewOrder);
            this.Controls.Add(this.adressViewDelivery);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxOrderState);
            this.Controls.Add(this.labelOrderDate);
            this.Controls.Add(this.label1);
            this.Name = "OrderDetailView";
            this.Size = new System.Drawing.Size(1026, 1009);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.ComboBox comboBoxOrderState;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private AdressView adressViewDelivery;
        private AdressView adressViewOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
