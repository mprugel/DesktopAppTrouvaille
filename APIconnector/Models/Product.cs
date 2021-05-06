using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{
    public class Product
    {
        
        public int ProductID { get; set; } = -1;
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public float Price { get; set; } = 0;
        public float Tax { get; set; } = 0;
        public int InStock { get; set; } = 0;
        public int MinStock { get; set; } = 0;
        public string Manufacturer { get; set; } = "";

    }
}
