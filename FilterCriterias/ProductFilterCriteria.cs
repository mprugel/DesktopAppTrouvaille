

using System;

namespace DesktopAppTrouvaille.FilterCriterias
{
    public class ProductFilterCriteria : FilterCriteria
    {
        public int InStockFrom;
        public int InStockTo;
        public Guid CategroryID;

        public ProductFilterCriteria(int inStockFrom, int inStockTo, Guid categroryID)
        {
            InStockFrom = inStockFrom;
            InStockTo = inStockTo;
            CategroryID = categroryID;
        }
    }
}
