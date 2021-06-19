using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Enums
{
    // Attributes to Sort
    public enum ProductSortCriteria { Name, InStock }

    public enum OrderSortCriteria { Date}

    public enum CustomerSortCriteria { Fisrtname, Lastname, OrderCount}

    // Order of Sorting
    public enum SortingOrder { Ascending, Descending }

}
