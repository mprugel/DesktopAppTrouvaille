using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille.Controllers
{
    public interface IMainController
    {
        void Login(LoginEmployeeModel user);
        void Logout();

        State GetState();
    }
}
