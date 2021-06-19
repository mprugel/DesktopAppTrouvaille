using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{
    class PutAddressViewModel
    {
        public string Country { get; set; }

        public string State { get; set; }

        public string Street { get; set; }

        public int? StreetNumber { get; set; }

        public int? PostalCode { get; set; }

        public string CityName { get; set; }
    }
}
