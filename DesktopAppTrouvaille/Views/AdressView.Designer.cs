namespace DesktopAppTrouvaille.Views
{
    partial class AdressView
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.numericUpDownStreetNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPostalCode = new System.Windows.Forms.NumericUpDown();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStreetNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPostalCode)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.numericUpDownPostalCode);
            this.groupBox3.Controls.Add(this.numericUpDownStreetNumber);
            this.groupBox3.Controls.Add(this.textBoxCountry);
            this.groupBox3.Controls.Add(this.textBoxCity);
            this.groupBox3.Controls.Add(this.textBoxStreet);
            this.groupBox3.Controls.Add(this.textBoxCustomerName);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 295);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adresse";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.Location = new System.Drawing.Point(22, 49);
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(380, 31);
            this.textBoxCustomerName.TabIndex = 7;
            this.textBoxCustomerName.Text = "Kundenname";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(22, 106);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(242, 31);
            this.textBoxStreet.TabIndex = 8;
            this.textBoxStreet.Text = "Straße";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(22, 211);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(380, 31);
            this.textBoxCity.TabIndex = 10;
            this.textBoxCity.Text = "Ort";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(22, 248);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(380, 31);
            this.textBoxCountry.TabIndex = 11;
            this.textBoxCountry.Text = "Land";
            // 
            // numericUpDownStreetNumber
            // 
            this.numericUpDownStreetNumber.Location = new System.Drawing.Point(287, 106);
            this.numericUpDownStreetNumber.Name = "numericUpDownStreetNumber";
            this.numericUpDownStreetNumber.Size = new System.Drawing.Size(115, 31);
            this.numericUpDownStreetNumber.TabIndex = 13;
            // 
            // numericUpDownPostalCode
            // 
            this.numericUpDownPostalCode.Location = new System.Drawing.Point(22, 156);
            this.numericUpDownPostalCode.Name = "numericUpDownPostalCode";
            this.numericUpDownPostalCode.Size = new System.Drawing.Size(380, 31);
            this.numericUpDownPostalCode.TabIndex = 14;
            // 
            // AdressView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Name = "AdressView";
            this.Size = new System.Drawing.Size(427, 295);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStreetNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPostalCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.NumericUpDown numericUpDownPostalCode;
        private System.Windows.Forms.NumericUpDown numericUpDownStreetNumber;
    }
}
