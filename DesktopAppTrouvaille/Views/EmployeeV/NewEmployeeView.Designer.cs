namespace DesktopAppTrouvaille.Views.EmployeeV
{
    partial class NewEmployeeView
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPasswordReType = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPasswordNotValid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(7052, 23);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Text = "Anlegen";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 533);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Passwort";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 615);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Passwort wiederholen";
            // 
            // textBoxPasswordReType
            // 
            this.textBoxPasswordReType.Location = new System.Drawing.Point(302, 610);
            this.textBoxPasswordReType.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPasswordReType.Name = "textBoxPasswordReType";
            this.textBoxPasswordReType.PasswordChar = '*';
            this.textBoxPasswordReType.Size = new System.Drawing.Size(226, 31);
            this.textBoxPasswordReType.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(302, 533);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(226, 31);
            this.textBoxPassword.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 742);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(457, 150);
            this.label6.TabIndex = 12;
            this.label6.Text = "Passwort muss folgende Kriterien erfüllen:\r\n\r\nMindestens 6 Zeichen lang.\r\nMindest" +
    "ens eine Zahl.\r\nMindestens ein Sonderzeichen. \r\nKlein- und Großbuchstaben.\r\n";
            // 
            // labelPasswordNotValid
            // 
            this.labelPasswordNotValid.AutoSize = true;
            this.labelPasswordNotValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordNotValid.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordNotValid.Location = new System.Drawing.Point(596, 615);
            this.labelPasswordNotValid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPasswordNotValid.Name = "labelPasswordNotValid";
            this.labelPasswordNotValid.Size = new System.Drawing.Size(208, 26);
            this.labelPasswordNotValid.TabIndex = 18;
            this.labelPasswordNotValid.Text = "Passwort ungültig!";
            this.labelPasswordNotValid.Visible = false;
            // 
            // NewEmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPasswordNotValid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxPasswordReType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(6000, 0);
            this.Name = "NewEmployeeView";
            this.Size = new System.Drawing.Size(6000, 1185);
            this.Controls.SetChildIndex(this.labelEmailNotValid, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBoxPasswordReType, 0);
            this.Controls.SetChildIndex(this.textBoxPassword, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.labelPasswordNotValid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPasswordReType;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPasswordNotValid;
    }
}
