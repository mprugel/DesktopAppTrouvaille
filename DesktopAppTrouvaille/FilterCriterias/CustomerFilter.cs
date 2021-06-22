using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.FilterCriterias
{
    public class CustomerFilter
    {
        public bool SearchGuid = false;
        public Guid CustomerGuid = new Guid();
        public string Email;

        public CustomerFilter(bool searchGuid, string email)
        {
            SearchGuid = searchGuid;
            
            Email = email;
        }
    }
}
