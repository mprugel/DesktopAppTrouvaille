using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{
    class Order
    {
        public int OrderID { get; set; }
        public string Date { get; set; }
        public string PaymentMethod { get; set; }
        public string ShippingMethod { get; set; }
        public int InvoiceID { get; set; }
        public string OrderState { get; set; }

    }
}
