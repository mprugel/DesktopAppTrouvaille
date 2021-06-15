namespace DesktopAppTrouvaille.Views
{
    partial class FilterBox
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
            System.Windows.Forms.CheckBox checkBoxFilter;
            checkBoxFilter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxFilter
            // 
            checkBoxFilter.AutoSize = true;
            checkBoxFilter.Location = new System.Drawing.Point(42, 52);
            checkBoxFilter.Name = "checkBoxFilter";
            checkBoxFilter.Size = new System.Drawing.Size(104, 29);
            checkBoxFilter.TabIndex = 0;
            checkBoxFilter.Text = "Filtern";
            checkBoxFilter.UseVisualStyleBackColor = true;
            // 
            // FilterBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(checkBoxFilter);
            this.Name = "FilterBox";
            this.Size = new System.Drawing.Size(1221, 493);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
