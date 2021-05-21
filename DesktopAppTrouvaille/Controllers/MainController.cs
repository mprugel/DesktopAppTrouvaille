using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppTrouvaille
{
    // This Class handles the login and logout
    public class MainController : IMainController
    {
        private static bool _loggedIn;
        public static bool LoggedIn { get { return _loggedIn; } }
        private User _currentUser;
        private IView _view;

        public MainController(IView view)
        {
            _view = view;
            _loggedIn = false;
        }

        public void Login(User user)
        {
            // Call API to Login User:
            //...
            //Successfuly logged in:
            _loggedIn = true;
            _view.UpdateView();
        }

        public void Logout()
        {
            _loggedIn = false;
            _view.UpdateView();
        }

    }
}
