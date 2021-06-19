
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
            listView.Factory = new CategoryFactory();
            listView.Init();

            Controller.UpdateData();
        }

        public void UpdateView()
        {
            UpdateStatusLabel();
        }

        protected override IDetailView CreateDetailView(IModel model)
        {
            CategoryDetailView view = new CategoryDetailView();
            return view;
        }

        protected override IDetailView CreateNewView()
        {
            NewCategoryView view = new NewCategoryView();
            return view;
        }
    }
}
