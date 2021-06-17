using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DesktopAppTrouvaille.Models;

namespace DesktopAppTrouvaille.Views.CategoryV
{
    public partial class CategorySelection : UserControl
    {
        public CategorySelection()
        {
            InitializeComponent();
        }

        public void AddCategories(List<Guid> productCategories, List<Category> allCategories)
        {
            dataGridView1.Rows.Clear();
            foreach (Category cat in allCategories)
            {
                // Create new Row
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];

                // Add the data
                row.Cells[0].Value = cat.Name;
                row.Tag = cat.CategoryId;

                // Check the Categories the product is assigned to:
                if (CheckCategory(cat, productCategories))
                {
                    row.Cells["selection"].Value = true;
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
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells["selection"].Value))
                {
                    cats.Add((Guid)row.Tag);
                }
            }
            return cats;
        }
    }
}
