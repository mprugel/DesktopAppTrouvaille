using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }

        public DateTime Date { get; set; }

        public decimal TotalCost { get; set; }

        public Globals.Globals.PaymentMethod PaymentMethod { get; set; }

        public Globals.Globals.Shipmentmethod ShipmentMethod { get; set; }

        public Globals.Globals.OrderState OrderState { get; set; }

        public AddressViewModel DeliveryAddress { get; set; }

        public AddressViewModel InvoiceAddress { get; set; }

        public ICollection<PostOrderProductViewModel> Products { get; set; }

    }
}
