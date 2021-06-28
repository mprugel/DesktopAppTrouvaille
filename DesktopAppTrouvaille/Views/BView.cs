﻿using System;
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
                case State.SaveFailed:
                    labelStatus.Text = "Anlegen fehlgeschlagen!";
                    break;
                case State.UpdateFailed:
                    labelStatus.Text = "Speichern fehlgeschlagen!";
                    break;
                case State.Updated:
                    labelStatus.Text = "Erfolgreich geändert!";
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
            Controller.DetachView(detailView);
            panelDetailView.Controls.Clear();

            detailView = CreateNewView();
            detailView.SetController(Controller);
           
            Controller.AttachView(detailView);

            UserControl control = (UserControl)detailView;
            control.Dock = DockStyle.Fill;
            panelDetailView.Controls.Add(control);
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
                detailView = CreateDetailView((IModel)item.Tag);

                detailView.SetModel((IModel)item.Tag);
                detailView.SetController(Controller);

                if(panelDetailView.Controls.Count > 0)
                {
                    Controller.DetachView((IView)panelDetailView.Controls[0]);
                }
                panelDetailView.Controls.Clear();
                Controller.AttachView(detailView);
                Controller.SelectDetailModel((IModel)item.Tag);

                UserControl control = (UserControl)detailView;
                control.Dock = DockStyle.Fill;
                panelDetailView.Controls.Add(control);
                panelDetailView.Visible = true;
            }
            else
            {
                panelDetailView.Visible = false;
            } 
        }

    }
}
