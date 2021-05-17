using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: Change int ProductId to Guid ProductId

namespace DesktopAppTrouvaille.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public int InStock { get; set; }
        public int MinStock { get; set; }
#nullable enable
        public virtual ManufacturerModel? Manufacturer { get; set; }
        public PictureModel? Picture { get; set; }
#nullable disable
    }
}
