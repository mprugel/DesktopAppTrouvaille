using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{
    public class PutProductModel
    {
        
            public string Name { get; set; }

            public string Description { get; set; }

            public decimal Price { get; set; }

            public int? InStock { get; set; }

            public int? MinStock { get; set; }

            public decimal? Tax { get; set; }

            //Manufacturer
            public string ManufacturerEmail { get; set; }

            public string ManufacturerCatalogId { get; set; }



            //Image
            public string ImageTitle { get; set; }

            public byte[] ImageData { get; set; }

            public bool? IsDisabled { get; set; }

        public PutProductModel(Product product )
            {
                Name = product.Name;
                Description = product.Description;
                Price = product.Price;
                InStock = product.InStock;
                MinStock = product.MinStock;
                Tax = product.Tax;
                IsDisabled = product.IsDisabled;
            }
        }
    }

