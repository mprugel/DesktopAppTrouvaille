using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
            
        public decimal Price { get; set; }

        public Guid? ManufacturerId { get; set; }

        public int? InStock { get; set; }

        public decimal? Tax { get; set; }

        public Guid? PictureId { get; set; }

        public virtual Picture Picture { get; set; }

        public virtual List<Guid> ProductCategories { get; set; }
          
        public virtual ICollection<Guid> Ratings { get; set; }

        public decimal? AverageRating { get; set; }

        public int ProductID { get; set; }

        public int MinStock { get; set; }

        public List<Category> Categories { get; set; }

    }
}
