using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille;
using DesktopAppTrouvaille.Views;
using DesktopAppTrouvaille.FilterCriterias;

namespace DesktopAppTrouvaille
{
    // This Class handles the login and logout
    public class MainController : IMainController
    {
        private static bool _loggedIn;
        public static bool LoggedIn { get { return _loggedIn; } }
        private User _currentUser;
        private IMainView _view;

        public ProductController productController = new ProductController();
        public OrderController orderController;


        public MainController(IMainView view)
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

        public void ShowProduct(Product p)
        {
            productController = new ProductController();
            _view.ShowProductView();
            productController.LoadCategories();
            productController.SelectDetailModel(p);

        }

        public void ShowOrders(Customer customer)
        {
            orderController = new OrderController(this);
            _view.ShowOrderView();
           //TODO send Search...
        }

    }
}
