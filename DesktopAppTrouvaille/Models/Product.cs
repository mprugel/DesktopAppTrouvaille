using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{
    public class Product
    {
        
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public float Tax { get; set; }
        public int InStock { get; set; }
        public int MinStock { get; set; }
        public string Manufacturer { get; set; }

    }
}
