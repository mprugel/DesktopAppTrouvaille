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
using System.Resources;

namespace DesktopAppTrouvaille.Views
{
    public partial class AdressView : UserControl
    {
        // Property for setting the title in the Designer:
        public string Title { get { return groupBox3.Text; } set { groupBox3.Text = value; } }
        private bool _editable = true;
        public bool Editable {
            get { return _editable; } 
            set { _editable = value;
                SetEditable();
            }
        }
        private readonly Color errorColor = Color.FromArgb(200, 100, 100);

        private List<TextBox> textBoxes = new List<TextBox>();
        private List<NumericUpDown> numericBoxes = new List<NumericUpDown>();
       
          

        public AdressView()
        {
            InitializeComponent();
            textBoxCity.Validating += textBox_Validating;
            textBoxCountry.Validating += textBox_Validating;
            textBoxStreet.Validating += textBox_Validating;
            

            numericUpDownPostalCode.Validating += numericUpDown_Validating;
            numericUpDownStreetNumber.Validating += numericUpDown_Validating;
        }
        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider1.SetError(textBox, "Das Feld darf nicht leer sein!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        private void numericUpDown_Validating(object sender, CancelEventArgs e)
        {
            NumericUpDown updown = (NumericUpDown)sender;

            if (updown.Value <= 0)
            {
                e.Cancel = true;
                updown.Focus();
                errorProvider1.SetError(updown, "Ungültige Eingabe!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(updown, "");
            }
        }

        public AddressViewModel GetAddressFromView()
        {
            AddressViewModel address = new AddressViewModel();
            address.PostalCode = (int)numericUpDownPostalCode.Value;
            address.CityName = textBoxCity.Text;
            address.Country = textBoxCountry.Text;
            address.Street = textBoxStreet.Text;
            address.StreetNumber = (int)numericUpDownStreetNumber.Value;
            return address;
        }

        private void SetEditable()
        {
            foreach(TextBox box in textBoxes)
            {
                box.ReadOnly = !_editable;
                
            }
            foreach (NumericUpDown updown in numericBoxes)
            {
                updown.ReadOnly = !_editable;
                if(_editable)
                {
                    updown.Increment = 1;
                }
                else
                {
                    updown.Increment = 0;
                }
                
            }
        }

        public bool CheckInputFields()
        {                
            bool valid = true;

            foreach (TextBox box in textBoxes)
            {
                if (box.Text.Length <= 0)
                {
                    box.BackColor = errorColor;
                    valid = false;
                }
                else
                {
                    box.BackColor = Color.White;
                }
            }

       
            foreach(NumericUpDown upDown in numericBoxes)
            {
                if (upDown.Value <= 0)
                {
                   upDown.BackColor = errorColor;
                   valid = false;
                }
                else
                {
                    upDown.BackColor = Color.White;
                }
                

            }
            return valid;
        }

        public void SetAdress(AddressViewModel address)
        {
            if(address != null)
            {
                textBoxCountry.Text = address.Country;
                textBoxCity.Text = address.CityName;
                numericUpDownPostalCode.Value = address.PostalCode;
                textBoxStreet.Text = address.Street + " " + address.StreetNumber.ToString();
                numericUpDownStreetNumber.Value = address.StreetNumber;
            }
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
