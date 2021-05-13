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
        private ProductDetailView detailView;
        public ProductController Controller { get; set; }
        
        public void UpdateView()
        {
            listViewTemplate1.AddItems(CreateListViewItems(Controller.Products));
        }

        public ProductView()
        {
            Controller = new ProductController(this);

            InitializeComponent();
            //Hide Product Detail:
            panelDetailView.Visible = false;

            // Initialize the ListView:
            listViewTemplate1.SetTitle("Produktliste");
            listViewTemplate1.SetButtonText("Neues Produkt");

            listViewTemplate1.AddColumn("Produkt ID");
            listViewTemplate1.AddColumn("Produktname");
            listViewTemplate1.AddColumn("Lagerbestand");

            listViewTemplate1.AddClickHandler(ItemSelected);
            listViewTemplate1.AddButtonAddHandler(ButtonAddHandler);

            // Initially update:
            UpdateView();

        }
        private void ButtonAddHandler(object sender, EventArgs e)
        {
            panelDetailView.Controls.Clear();
            detailView = new NewProductView(Controller);
            panelDetailView.Controls.Add(detailView);
            panelDetailView.Visible = true;
        }

        private void ItemSelected(object sender, System.EventArgs e)
        {
            ListViewItem item = listViewTemplate1.GetSelectedItem();
            if(item != null)
            {
                Product p = (Product)item.Tag;

                panelDetailView.Controls.Clear();
                detailView = new ProductDetailView(Controller);
                panelDetailView.Controls.Add(detailView);

                detailView.Prod = p;
                detailView.UpdateView();
                panelDetailView.Visible = true;
            }
            else
            {
                detailView.Visible = false;
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
