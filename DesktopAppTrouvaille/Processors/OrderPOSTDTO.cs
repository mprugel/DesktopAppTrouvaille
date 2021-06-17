using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopAppTrouvaille.Models;

namespace DesktopAppTrouvaille.Processors
{
    public class OrderPOSTDTO
    {

        public AddressViewModel DeliveryAddress { get; set; }

        public AddressViewModel InvoiceAddress { get; set; }

        public ICollection<PostOrderProductViewModel> Products { get; set; }

    }
}

