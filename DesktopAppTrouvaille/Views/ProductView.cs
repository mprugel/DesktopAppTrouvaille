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
        public List<Product> Products { get; set; } = new List<Product>();

        private ProductController _controller = new ProductController();
      
        public void UpdateView()
        {
            listViewTemplate1.AddItems(CreateListViewItems(Products));
        }

        public ProductView()
        {
            InitializeComponent();
            //Hide Product Detail:
            productDetailView1.Visible = false;

            // Initialize the ListView:
            listViewTemplate1.SetTitle("Produktliste");
            listViewTemplate1.SetButtonText("Neues Produkt");

            listViewTemplate1.AddColumn("Produkt ID");
            listViewTemplate1.AddColumn("Produktname");
            listViewTemplate1.AddColumn("Lagerbestand");

            listViewTemplate1.AddClickHandler(ItemSelected);
            listViewTemplate1.AddButtonAddHandler(ButtonAddHandler);

            // Initialize the ProductDetailView:


        }
        private void ButtonAddHandler(object sender, EventArgs e)
        {
            productDetailView1.Prod = new Product();
            productDetailView1.UpdateView();
            productDetailView1.Visible = true;
            productDetailView1.SetTitle("Neues Produkt anlegen");
        }

        private void ItemSelected(object sender, System.EventArgs e)
        {
            ListViewItem item = listViewTemplate1.GetSelectedItem();
            if(item != null)
            {
                Product p = (Product)item.Tag;
                productDetailView1.Prod = p;
                productDetailView1.UpdateView();
                productDetailView1.Visible = true;
            }
            else
            {
                productDetailView1.Visible = false;
            } 
        }

        private List<ListViewItem> CreateListViewItems(List<Product> products)
        {
            List<ListViewItem> list = new List<ListViewItem>();
            foreach(Product p in products)
            {
                list.Add(CreateListViewItem(p));
            }
            return list;
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
