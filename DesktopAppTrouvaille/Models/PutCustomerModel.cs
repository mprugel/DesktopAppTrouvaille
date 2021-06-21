using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{
    public class PutCustomerModel
    {
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Boolean? IsDisabled { get; set; }

        public AddressViewModel InvoiceAddress { get; set; }

        public AddressViewModel DeliveryAddress { get; set; }
    }
}
