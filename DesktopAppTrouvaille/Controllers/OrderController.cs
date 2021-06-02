using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Controllers
{
    public class OrderController : Controller
    {
        private List<Order> orders = new List<Order>();

        public override int GetCount()
        {
            // TODO: Call API:
            return 100;
        }

      

        public override void UpdateData()
        {
            throw new NotImplementedException();
        }
    }
}
