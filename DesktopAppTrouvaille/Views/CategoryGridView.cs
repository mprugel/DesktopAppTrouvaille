using DesktopAppTrouvaille.Models;
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

        public void AddCategories(List<Category> productCategories, List<Category> allCategories)
        {
            foreach(Category cat in allCategories)
            {
                // Create new Row
                int rowId = Rows.Add();
                DataGridViewRow row = Rows[rowId];
                
                // Add the data
                row.Cells[0].Value = cat.Name;
                row.Tag = cat;
                // Check the Categories the product is assigned to:
                if(CheckCategory(cat,productCategories))
                {
                    row.Cells["Zuordnen"].Value = true;
                }
                
            }
        }

        private bool CheckCategory(Category cat, List<Category> categories)
        {
            foreach(Category c in categories)
            {
                if(c.Equals(cat))
                {
                    return true;
                }
            }
            return false;
        }

        public List<Category> GetCheckedCategories()
        {
            List<Category> cats = new List<Category>();
            foreach(DataGridViewRow row in Rows)
            {
                if (Convert.ToBoolean(row.Cells["Zuordnen"].Value))
                {
                    cats.Add((Category)row.Tag);
                }
            }
            return cats;
        }

    }
}
