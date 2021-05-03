namespace DesktopAppTrouvaille.Views
{
    partial class ProductDetailView
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDeletePicture = new System.Windows.Forms.Button();
            this.buttonUploadPicture = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produktbearbeitung";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(163, 120);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(155, 25);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Pinsel Größe 5";
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Location = new System.Drawing.Point(756, 120);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(60, 25);
            this.labelProductID.TabIndex = 2;
            this.labelProductID.Text = "1045";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(622, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Produkt ID:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(83, 225);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lagerbestand";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(308, 225);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 31);
            this.numericUpDown2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Beschreibung";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(141, 649);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 315);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(83, 357);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(733, 231);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(83, 1040);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(139, 48);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Löschen";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(532, 1040);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(284, 48);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Änderungen speichern";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 649);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 315);
            this.button1.TabIndex = 14;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(601, 649);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 315);
            this.button2.TabIndex = 15;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePicture
            // 
            this.buttonDeletePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletePicture.ForeColor = System.Drawing.Color.Red;
            this.buttonDeletePicture.Location = new System.Drawing.Point(676, 649);
            this.buttonDeletePicture.Name = "buttonDeletePicture";
            this.buttonDeletePicture.Size = new System.Drawing.Size(140, 75);
            this.buttonDeletePicture.TabIndex = 16;
            this.buttonDeletePicture.Text = "Löschen";
            this.buttonDeletePicture.UseVisualStyleBackColor = false;
            // 
            // buttonUploadPicture
            // 
            this.buttonUploadPicture.Location = new System.Drawing.Point(676, 753);
            this.buttonUploadPicture.Name = "buttonUploadPicture";
            this.buttonUploadPicture.Size = new System.Drawing.Size(140, 81);
            this.buttonUploadPicture.TabIndex = 17;
            this.buttonUploadPicture.Text = "Hochladen";
            this.buttonUploadPicture.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Name:";
            // 
            // ProductDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonUploadPicture);
            this.Controls.Add(this.buttonDeletePicture);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelProductID);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.label1);
            this.Name = "ProductDetailView";
            this.Size = new System.Drawing.Size(914, 1135);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDeletePicture;
        private System.Windows.Forms.Button buttonUploadPicture;
        private System.Windows.Forms.Label label6;
    }
}
