using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Enums
{
    // Attributes to Sort
    public enum ProductSortCriteria { Name, InStock ,Price}

    public enum OrderSortCriteria { Date}

    public enum CustomerSortCriteria { Firstname, Lastname, OrderCount}

    // Order of Sorting
    public enum SortingOrder { Ascending, Descending }

}
