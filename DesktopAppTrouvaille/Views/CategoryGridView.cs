using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppTrouvaille.Views
{
    class CategoryGridView : DataGridView
    {
        public CategoryGridView()
        {
            ColumnCount = 1;
            Columns[0].Name = "Kategoriename";
        

            DataGridViewCheckBoxColumn checkBoxCol = new DataGridViewCheckBoxColumn();
            checkBoxCol.Name = "Zuordnen";
            
            Columns.Add(checkBoxCol);
        }

        public void AddCategories(List<object> categories)
        {
            foreach(object cat in categories)
            {
                int rowId = Rows.Add();

                // Grab the new row!
                DataGridViewRow row = Rows[rowId];

                // Add the data
                row.Cells["Column1"].Value = "Value1";
                row.Tag = cat;
                Rows.Add(row);
            }
        }

        public List<object> GetCheckedCategories()
        {
            List<object> cats = new List<object>();
            foreach(DataGridViewRow row in Rows)
            {
                if (Convert.ToBoolean(row.Cells["Zuordnen"].Value))
                {
                    cats.Add(row.Tag);
                }
            }
            return cats;
        }

    }
}
