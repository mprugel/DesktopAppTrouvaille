﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{
    public class AddressModel
    {
        public Guid AddressId { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public string Street { get; set; }

        public int StreetNumber { get; set; }
        public Guid CityId { get; set; }

        public virtual CityModel City { get; set; }
    }
}
