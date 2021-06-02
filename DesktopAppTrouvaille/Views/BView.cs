using System;
using System.Windows.Forms;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Factories;

namespace DesktopAppTrouvaille.Views
{
    public partial class BView : UserControl 
    {
        private IDetailView detailView;
       
        public Controller Controller { get; set; }
        
        public void UpdateStatusLabel()
        {
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
                    labelStatus.Text = "Erfolgreich gelöscht";
                    panelDetailView.Controls.Clear();
                    break;
                case State.Saved:
                    panelDetailView.Controls.Clear();
                    labelStatus.Text = "Erfolgreich gespeichert";
                    break;
            }
        }

        public BView()
        {
            InitializeComponent();
            //Hide Product Detail:
            panelDetailView.Visible = false;
            listView.AddClickHandler(ItemSelected);
            listView.AddButtonAddHandler(ButtonAddHandler);

        }

       
        private void ButtonAddHandler(object sender, EventArgs e)
        {
            panelDetailView.Controls.Clear();
            detailView = CreateNewView();
            detailView.SetController(Controller);
            panelDetailView.Controls.Add((UserControl)detailView);
            panelDetailView.Visible = true;
        }
        protected virtual IDetailView CreateNewView()
        {
            return null;
        }
        protected virtual IDetailView CreateDetailView(IModel model)
        {
            return null;
        }

        private void ItemSelected(object sender, System.EventArgs e)
        {
            ListViewItem item = listView.GetSelectedItem();
            if(item != null)
            {
                panelDetailView.Controls.Clear();
                detailView = CreateDetailView((IModel)item.Tag);
                detailView.SetModel((IModel)item.Tag);
                detailView.SetController(Controller);
                panelDetailView.Controls.Add((UserControl)detailView);
                detailView.UpdateView();
                panelDetailView.Visible = true;
            }
            else
            {
                panelDetailView.Visible = false;
            } 
        }

    }
}
