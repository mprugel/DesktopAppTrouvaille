using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Models
{
    class CategoryModel
    {
        public Guid CategoryId { get; set; }

        public string Name { get; set; }

        public int ProductCounter { get; set; }

        public virtual ICollection<ProductModel> Products { get; set; }
    }
}
