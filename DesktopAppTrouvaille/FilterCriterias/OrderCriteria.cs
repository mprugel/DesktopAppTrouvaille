using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesktopAppTrouvaille.Globals.Globals;

namespace DesktopAppTrouvaille.FilterCriterias
{
    public class OrderCriteria
    {
        public DateTime OrderDateFrom;
        public DateTime OrderDateTo;
        public Guid CustomerGuid;
        public OrderState OrderState;
        
    }
}
