using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppTrouvaille.Views
{
    public partial class DetailViewBase : UserControl , IView
    {
        public DetailViewBase()
        {
            InitializeComponent();
        }

        public virtual void UpdateView()
        {
            this.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Enabled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Enabled = false;
        }
    }
}
