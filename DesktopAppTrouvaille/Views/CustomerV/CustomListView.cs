using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppTrouvaille.Views
{
    class CustomListView : ListView
    {
        public CustomListView()
        {
            View = View.Details;

            FullRowSelect = true;
            GridLines = true;
            HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            HideSelection = false;
            MultiSelect = false;
            TabIndex = 7;
            TileSize = new System.Drawing.Size(100, 10);
            UseCompatibleStateImageBehavior = false;
        }
    }
}
