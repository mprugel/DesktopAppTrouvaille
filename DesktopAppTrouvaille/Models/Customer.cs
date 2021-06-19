

using System;
using System.Collections.Generic;

namespace DesktopAppTrouvaille.Models
{
    public class Customer : IModel
    {
        public string Id { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public AddressViewModel InvoiceAddress { get; set; }

        public AddressViewModel DeliveryAddress { get; set; }

        public ICollection<Guid> Orders { get; set; }


        public Customer(){}

        public Guid GetGuid()
        {
            throw new NotImplementedException();
        }
    }
}
