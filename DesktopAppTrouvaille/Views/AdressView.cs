﻿using System;
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
    public partial class AdressView : UserControl
    {
        // Property for setting the title in the Designer:
        public string Title { get { return groupBox3.Text; } set { groupBox3.Text = value; } }

        public AdressView()
        {
            InitializeComponent();
        }

        public void SetAdress(AddressViewModel address)
        {
            labelCountry.Text = address.Country;
            labelCity.Text = address.CityName;
            labelPostalCode.Text = address.PostalCode.ToString();
            labelStreet.Text = address.Street + " " + address.StreetNumber.ToString();
        }
    }
}
