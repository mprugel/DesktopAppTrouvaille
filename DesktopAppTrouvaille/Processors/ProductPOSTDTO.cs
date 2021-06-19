using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Processors
{
    public class ProductPOSTDTO
    {
       
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int InStock { get; set; }

        public int MinStock { get; set; }

        public decimal Tax { get; set; }

        //Manufacturer
        public string ManufacturerEmail { get; set; }

        public string ManufacturerCatalogId { get; set; }
        //

        public string ImageTitle { get; set; }

        public byte[] ImageData { get; set; }


        public ICollection<Guid> ProductCategoryIds { get; set; }

    }
}
