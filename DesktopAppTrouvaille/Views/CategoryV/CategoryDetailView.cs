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
    public partial class CategoryDetailView : UserControl, IView
    {
        public string Title { get { return labelTitel.Text; } set { labelTitel.Text = value; } }
        public string SaveButtonText { get { return buttonSave.Text; } set { buttonSave.Text = value; } }

        private bool _displaySaveButton = true;
        public bool DisplayDeleteButton
        {
            get { return _displaySaveButton; }
            set
            {
                _displaySaveButton = value;
                buttonDelete.Visible = value;
            }
        }

        public CategoryDetailView()
        {
            InitializeComponent();
        }

        public void UpdateView()
        {
            throw new NotImplementedException();
        }
    }
}
