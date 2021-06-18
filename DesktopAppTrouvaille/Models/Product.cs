using DesktopAppTrouvaille.Processors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{
    public class Product : IModel
    {
        public Guid ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; } = 0;

        public Guid? ManufacturerId { get; set; }

        public int? InStock { get; set; } = 0;

        public decimal? Tax { get; set; } = 0;

        public Guid? PictureId { get; set; }

        public virtual Picture Picture { get; set; } = new Picture();

        public virtual List<Guid> ProductCategories { get; set; } = new List<Guid>();
          
        public virtual ICollection<Guid> Ratings { get; set; }

        public decimal? AverageRating { get; set; } = 0;

        public int MinStock { get; set; } = 0;

        public Guid GetGuid()
        {
            return ProductId;
        }

        // public List<Category> Categories { get; set; } = new List<Category>();

        public ProductPOSTDTO toPOSTDTO()
        {
            ProductPOSTDTO dto = new ProductPOSTDTO();
            dto.Name = Name;
            dto.Description = Description;
            dto.Price = Price;
            dto.InStock = InStock;
            dto.MinStock = MinStock;
            dto.Tax = Tax;
            dto.ManufacturerId = ManufacturerId;
            if(Picture != null)
            {
                dto.ImageTitle = Picture.ImageTitle;
                dto.ImageData = Picture.ImageData;
            }
           
            dto.ProductCategoryIds = ProductCategories.ToList<Guid>();

            return dto;
        }

        public override bool Equals(object obj)
        {
            if(obj != null && obj is Product)
            {
                Product p = (Product)obj;
                if(p.ProductId.Equals(ProductId))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
