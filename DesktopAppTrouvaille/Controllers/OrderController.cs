using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;

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

        public override IEnumerable<IModel> GetModels()
        {
            throw new NotImplementedException();
        }

        public override void UpdateData()
        {
            throw new NotImplementedException();
        }
    }
}
