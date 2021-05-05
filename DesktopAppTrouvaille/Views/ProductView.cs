using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAppTrouvaille.Models;

namespace DesktopAppTrouvaille.Views
{
    public partial class ProductView : UserControl, IView
    {
        public ProductView()
        {
            InitializeComponent();

            // Set the Title of the ListView Box:
            listViewTemplate1.SetTitle("Produktliste");
            // Initialize the ListView:
            listViewTemplate1.AddColumn("Produkt ID");
            listViewTemplate1.AddColumn("Produktname");
            listViewTemplate1.AddColumn("Lagerbestand");

            //----------------------------------------------------
            //Add a Test Product:
            Product p = new Product();
            p.Name = "Pinsel";
            p.ProductID = 20;
            p.InStock = 120;
            listViewTemplate1.AddItem(CreateListViewItem(p));
            //-----------------------------------------------------

            listViewTemplate1.AddSelectedItemHandler(ItemSelected);

       
        }

        private void ItemSelected(object sender, System.EventArgs e)
        {
            
            ListViewItem item = listViewTemplate1.GetSelectedItem();
            if(item != null)
            {
                Product p = (Product)item.Tag;
                Console.WriteLine("Item selected:" + p.Name.ToString());
            }
            
        }


        private ListViewItem CreateListViewItem(Product product)
        {
            string[] stringItems = { product.ProductID.ToString(), product.Name.ToString(), product.InStock.ToString() };
            ListViewItem item = new ListViewItem(stringItems,1);
            item.Tag = product;
            return item;
        }

        
    }
}
