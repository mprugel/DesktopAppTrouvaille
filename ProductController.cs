using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille
{
    public class ProductController
    {
        // NoOT USED YET:
        private IProductState state;

        // List of Products:
        public List<ProductModel> Products;

        // Interface for Updating the GUI:
        private IView _view;

        public ProductController(IView view)
        {
            _view = view;
            Products = new List<ProductModel>();
            ProductModel p1 = new ProductModel();
            p1.Name = "Pinsel Größe 5";
            p1.Price = 2;
            p1.ProductId = 45;

            ProductModel p2 = new ProductModel();
            p2.Name = "Pinsel Größe 10";
            p2.Price = 3;
            p2.ProductId = 51;

            Products.Add(p1);
            Products.Add(p2);
        }

        public void UpdateData()
        {
            // Call API
        }

        public void SaveProduct(ProductModel p)
        {
            // Call API
           
            // Check Result from API Call:

            // Update GUI If No Error Occured :
            _view.UpdateView();
        }

        public void ItemSelected(ProductModel p)
        {
            state = state.ItemSelected(this);
        }

        public void UpdateProduct(ProductModel p)
        {
            // Call API
        }

       
    }
}
