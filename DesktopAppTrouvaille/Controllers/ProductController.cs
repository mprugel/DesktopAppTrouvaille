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
        public List<Product> Products;

        // Interface for Updating the GUI:
        private IView _view;

        public ProductController(IView view)
        {
            _view = view;
            Products = new List<Product>();
            Product p1 = new Product();
            p1.Name = "Pinsel Größe 5";
            p1.Price = 2;
            p1.ProductID = 45;

            Product p2 = new Product();
            p2.Name = "Pinsel Größe 10";
            p2.Price = 3;
            p2.ProductID = 51;

            Products.Add(p1);
            Products.Add(p2);
        }

        public void UpdateData()
        {
            // Call API
        }

        public void SaveProduct(Product p)
        {
            // Call API
            //...
           
            // Check Result from API Call:
            //...

            // Update GUI If No Error Occured :
            // Show new Item in DetailView:
           
        }

        public void ItemSelected(Product p)
        {
            state = state.ItemSelected(this);
        }

        public void UpdateProduct(Product p)
        {
            // Call API 
            //...
            
            _view.UpdateView();
        }

       
    }
}
