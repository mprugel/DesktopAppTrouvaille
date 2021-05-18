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

        public void AddCategories(List<CategoryModel> productCategories, List<CategoryModel> allCategories)
        {
            foreach(CategoryModel cat in allCategories)
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

        private bool CheckCategory(CategoryModel cat, List<CategoryModel> categories)
        {
            if (categories != null)
            {
                foreach (CategoryModel c in categories)
                {
                    if (c.Equals(cat))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public List<CategoryModel> GetCheckedCategories()
        {
            List<CategoryModel> cats = new List<CategoryModel>();
            foreach(DataGridViewRow row in Rows)
            {
                if (Convert.ToBoolean(row.Cells["Zuordnen"].Value))
                {
                    cats.Add((CategoryModel)row.Tag);
                }
            }
            return cats;
        }

    }
}
