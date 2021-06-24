

using System;
using System.Collections.Generic;

namespace DesktopAppTrouvaille.FilterCriterias
{
    public class ProductFilterCriteria : FilterCriteria
    {
        public int InStockFrom;
        public int InStockTo;
        public List<Guid> CategroryIDs = new List<Guid>();

        public ProductFilterCriteria(int inStockFrom, int inStockTo, List<Guid> categroryIDs)
        {
            InStockFrom = inStockFrom;
            InStockTo = inStockTo;
            CategroryIDs = categroryIDs;
        }
    }
}
