using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille
{
    public class ProductController
    {
        public Product DetailProduct;

        private IProductState state;

        public List<Product> Products;

        public void UpdateData()
        {
            // Call API
        }

        public void ClickSave(Product p)
        {
            state = state.ClickSave(this);
        }

        public void ItemSelected(Product p)
        {
            state = state.ItemSelected(this);
        }

        public void UpdateProduct(Product p)
        {
            // Call API
        }

       
    }
}
