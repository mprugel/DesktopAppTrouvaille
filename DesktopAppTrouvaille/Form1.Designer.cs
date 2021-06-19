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
            this.mainMenuUC1 = new DesktopAppTrouvaille.Views.MainView();
            this.SuspendLayout();
            // 
            // mainMenuUC1
            // 
            this.mainMenuUC1.AutoSize = true;
            this.mainMenuUC1.BackColor = System.Drawing.Color.White;
            this.mainMenuUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuUC1.Location = new System.Drawing.Point(0, 0);
            this.mainMenuUC1.Margin = new System.Windows.Forms.Padding(1);
            this.mainMenuUC1.Name = "mainMenuUC1";
            this.mainMenuUC1.Size = new System.Drawing.Size(1487, 648);
            this.mainMenuUC1.TabIndex = 2;
            this.mainMenuUC1.Load += new System.EventHandler(this.mainMenuUC1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1487, 648);
            this.Controls.Add(this.mainMenuUC1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(967, 539);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MainView mainMenuUC1;
    }
}

