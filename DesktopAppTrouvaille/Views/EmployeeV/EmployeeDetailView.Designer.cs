namespace DesktopAppTrouvaille.Views.EmployeeV
{
    partial class EmployeeDetailView
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFistName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.adressView1 = new DesktopAppTrouvaille.Views.AdressView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mitarbeiter bearbeiten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vorname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nachname";
            // 
            // textBoxFistName
            // 
            this.textBoxFistName.Location = new System.Drawing.Point(183, 131);
            this.textBoxFistName.Name = "textBoxFistName";
            this.textBoxFistName.Size = new System.Drawing.Size(339, 31);
            this.textBoxFistName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(183, 179);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(339, 31);
            this.textBoxLastName.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(385, 1054);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 77);
            this.button1.TabIndex = 6;
            this.button1.Text = "Änderungen speichern";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(27, 1051);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 82);
            this.button2.TabIndex = 7;
            this.button2.Text = "Löschen";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // adressView1
            // 
            this.adressView1.Editable = true;
            this.adressView1.Location = new System.Drawing.Point(27, 258);
            this.adressView1.Name = "adressView1";
            this.adressView1.Size = new System.Drawing.Size(495, 295);
            this.adressView1.TabIndex = 3;
            this.adressView1.Title = "Adresse";
            this.adressView1.Load += new System.EventHandler(this.adressView1_Load);
            // 
            // EmployeeDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFistName);
            this.Controls.Add(this.adressView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeDetailView";
            this.Size = new System.Drawing.Size(794, 1158);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private AdressView adressView1;
        private System.Windows.Forms.TextBox textBoxFistName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Button button2;
    }
}
