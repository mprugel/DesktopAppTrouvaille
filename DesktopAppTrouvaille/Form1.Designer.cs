using DesktopAppTrouvaille.Views;

namespace DesktopAppTrouvaille
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenuUC1 = new DesktopAppTrouvaille.Views.MainView();
            this.SuspendLayout();
            // 
            // mainMenuUC1
            // 
            this.mainMenuUC1.AutoSize = true;
            this.mainMenuUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainMenuUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuUC1.Location = new System.Drawing.Point(0, 0);
            this.mainMenuUC1.Margin = new System.Windows.Forms.Padding(0);
            this.mainMenuUC1.Name = "mainMenuUC1";
            this.mainMenuUC1.Size = new System.Drawing.Size(1487, 861);
            this.mainMenuUC1.TabIndex = 2;
            this.mainMenuUC1.Load += new System.EventHandler(this.mainMenuUC1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1487, 861);
            this.Controls.Add(this.mainMenuUC1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1500, 850);
            this.Name = "Form1";
            this.Text = "Trouvaille Desktop App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MainView mainMenuUC1;
    }
}

