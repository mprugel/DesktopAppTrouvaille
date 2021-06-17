using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Processors
{
    public class SearchQueryDTO
    {
        public bool asc = true;
        public ICollection<Guid> categoryIds = null;
        public string orderBy = "Price";
    }
}
