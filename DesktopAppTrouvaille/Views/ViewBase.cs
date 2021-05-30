using DesktopAppTrouvaille.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppTrouvaille.Views
{
    // Abstract Base Class for all Views 
    public class ViewBase : UserControl
    {
        public Panel panelDetailView;
        public ListViewTemplate listViewTemplate1;

        private void InitializeComponent()
        {
            this.panelDetailView = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listViewTemplate1
            // 
            this.listViewTemplate1.AddButtonText = "ADD <Item>";
            this.listViewTemplate1.AutoSize = true;
            this.listViewTemplate1.BackColor = System.Drawing.Color.White;
            this.listViewTemplate1.DisplayAddButton = true;
            this.listViewTemplate1.Location = new System.Drawing.Point(16, 15);
            this.listViewTemplate1.Name = "listViewTemplate1";
            this.listViewTemplate1.Size = new System.Drawing.Size(744, 963);
            this.listViewTemplate1.TabIndex = 0;
            this.listViewTemplate1.Title = "TITEL";
            // 
            // panelDetailView
            // 
            this.panelDetailView.Location = new System.Drawing.Point(790, 15);
            this.panelDetailView.Name = "panelDetailView";
            this.panelDetailView.Size = new System.Drawing.Size(784, 963);
            this.panelDetailView.TabIndex = 1;
            // 
            // View
            // 
            this.Controls.Add(this.panelDetailView);
            this.Controls.Add(this.listViewTemplate1);
            this.Name = "View";
            this.Size = new System.Drawing.Size(1645, 1057);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public ViewBase()
        {
            InitializeComponent();
        }
      
    }
}
