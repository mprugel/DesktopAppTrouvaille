using System;
using System.Windows.Forms;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Views.VProduct;

namespace DesktopAppTrouvaille.Views.VProduct
{
    public partial class ProductView : ViewBase, IView
    {

        private ProductDetailView detailView;
        private ListItemFactory itemFactory = new ProdoctItemFactory();
        public ProductController Controller { get; set; }

        public void UpdateView()
        {
            listViewTemplate1.AddItems();
            listViewTemplate1.UpdateView();
            switch (Controller.state)
            {
                case State.ConnectionError:
                    labelStatus.Text = "Ein Verbindungsfehler ist aufgetreten!";
                    break;
                case State.OK:
                    labelStatus.Text = String.Empty;
                    break;
                case State.LoadData:
                    labelStatus.Text = "Lade Daten vom Server...";
                    break;
                case State.SendingData:
                    labelStatus.Text = "Sende Daten zum Server...";
                    break;
                case State.Deleted:
                    labelStatus.Text = "Produkt wurde gelöscht";
                    panelDetailView.Controls.Clear();
                    break;
                case State.Saved:
                    panelDetailView.Controls.Clear();
                    labelStatus.Text = "Produkt wurde gespeichert";
                    break;
            }
        }

        public ProductView()
        {
            Controller = new ProductController();
            Controller.AttachView(this);

            InitializeComponent();
            listViewTemplate1.Controller = Controller;
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
            Controller.UpdateData();
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
            if (item != null)
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


    }
}
