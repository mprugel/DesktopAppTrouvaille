using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Processors
{
    class CategoryGETDTO
    {
        public Guid CategoryId { get; set; }

        public string Name { get; set; }

        public int ProductCounter { get; set; }
        public ICollection<Guid> ProductIds { get; set; }
    }
}
