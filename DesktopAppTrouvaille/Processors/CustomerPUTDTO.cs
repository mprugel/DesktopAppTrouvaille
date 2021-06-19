using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopAppTrouvaille.Models;

namespace DesktopAppTrouvaille.Processors
{
    class CustomerPUTDTO
    {
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public PutAddressViewModel InvoiceAddress { get; set; }

        public PutAddressViewModel DeliveryAddress { get; set; }
    }
}
