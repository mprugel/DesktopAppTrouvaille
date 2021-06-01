
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Factories;
using DesktopAppTrouvaille.Views.CategoryV;

namespace DesktopAppTrouvaille.Views
{
    public partial class CategoryView : BView, IView
    {
        public CategoryView()
        {
            InitializeComponent();
            Controller = new CategoryController();
            Controller.AttachView(this);
            Controller.AttachView(listView);
            listView.Controller = Controller;
            listView.Factory = new OrderItemFactory();
            listView.Init();
        }

        public void UpdateView()
        {
            UpdateStatusLabel();
        }

        protected override IView CreateDetailView(IModel model)
        {
            CategoryDetailView view = new CategoryDetailView();
            return view;
        }

        protected override IView CreateNewView()
        {
            NewCategoryView view = new NewCategoryView();
            return view;
        }
    }
}
