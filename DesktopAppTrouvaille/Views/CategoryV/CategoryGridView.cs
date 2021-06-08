using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DesktopAppTrouvaille.Views
{
    public class CategoryGridView : DataGridView
    {
        public CategoryGridView()
        {
            ColumnCount = 1;
            Columns[0].Name = "Kategoriename";

            DataGridViewCheckBoxColumn checkBoxCol = new DataGridViewCheckBoxColumn();
            checkBoxCol.Name = "Zuordnen";
            
            Columns.Add(checkBoxCol);
        }

        public void AddCategories(List<Guid> productCategories, List<Category> allCategories)
        {
            this.Rows.Clear();
            foreach(Category cat in allCategories)
            {
                // Create new Row
                int rowId = Rows.Add();
                DataGridViewRow row = Rows[rowId];
                
                // Add the data
                row.Cells[0].Value = cat.Name;
                row.Tag = cat.CategoryId;
               
                // Check the Categories the product is assigned to:
                if (CheckCategory(cat,productCategories))
                {
                    row.Cells["Zuordnen"].Value = true;
                }
                
            }
        }

        private bool CheckCategory(Category cat, List<Guid> categories)
        {
            if (categories != null)
            {
                foreach (Guid guid in categories)
                {
                    if (guid.Equals(cat.CategoryId))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public List<Guid> GetCheckedCategories()
        {
            List<Guid> cats = new List<Guid>();
            foreach(DataGridViewRow row in Rows)
            {
                if (Convert.ToBoolean(row.Cells["Zuordnen"].Value))
                {
                    cats.Add((Guid)row.Tag);
                }
            }
            return cats;
        }

    }
}
