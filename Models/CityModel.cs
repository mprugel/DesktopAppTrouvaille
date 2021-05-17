using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{
    public class CityModel
    {
        public Guid CityId { get; set; }

        public int PostalCode { get; set; }

        public string Name { get; set; }
    }
}
