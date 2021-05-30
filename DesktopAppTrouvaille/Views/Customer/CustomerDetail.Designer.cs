namespace DesktopAppTrouvaille.Views
{
    partial class CustomerDetail
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
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.adressView1 = new DesktopAppTrouvaille.Views.AdressView();
            this.adressView2 = new DesktopAppTrouvaille.Views.AdressView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kundenansicht";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(18, 1052);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(284, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Deaktivieren";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 25);
            this.label16.TabIndex = 16;
            this.label16.Text = "Name: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(124, 164);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(178, 25);
            this.label17.TabIndex = 17;
            this.label17.Text = "Max Mustermann";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(636, 1052);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(288, 58);
            this.button2.TabIndex = 18;
            this.button2.Text = "Bestellungen anzeigen";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // adressView1
            // 
            this.adressView1.Location = new System.Drawing.Point(28, 286);
            this.adressView1.Name = "adressView1";
            this.adressView1.Size = new System.Drawing.Size(368, 266);
            this.adressView1.TabIndex = 19;
            this.adressView1.Title = "Rechnungsdresse";
            // 
            // adressView2
            // 
            this.adressView2.Location = new System.Drawing.Point(457, 286);
            this.adressView2.Name = "adressView2";
            this.adressView2.Size = new System.Drawing.Size(410, 266);
            this.adressView2.TabIndex = 20;
            this.adressView2.Title = "Lieferadresse";
            // 
            // CustomerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.adressView2);
            this.Controls.Add(this.adressView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "CustomerDetail";
            this.Size = new System.Drawing.Size(948, 1128);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button2;
        private AdressView adressView1;
        private AdressView adressView2;
    }
}
