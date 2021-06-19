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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(529, 51);
            this.label1.Text = "Neuen Mitarbeiter anlegen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 1054);
            this.button1.Text = "Anlegen";
            // 
            // button2
            // 
            this.button2.Visible = false;
            // 
            // NewEmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "NewEmployeeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
