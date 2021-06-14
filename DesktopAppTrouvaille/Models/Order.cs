using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{
    public class Order : IModel
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

        public Guid GetGuid()
        {
            return OrderId;
        }
        public Order() { }
        public Order(Order other)
        {
            OrderId = other.OrderId;
            Date = other.Date;
            TotalCost = other.TotalCost;
            PaymentMethod = other.PaymentMethod;
            ShipmentMethod = other.ShipmentMethod;
            OrderState = other.OrderState;
            DeliveryAddress = other.DeliveryAddress;
            InvoiceAddress = other.InvoiceAddress;
            if(other.Products != null)
            {
                Products = other.Products.ToList();
            }

        }
    }
}
