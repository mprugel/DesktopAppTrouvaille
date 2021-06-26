
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Factories;
using DesktopAppTrouvaille.Views.CategoryV;

namespace DesktopAppTrouvaille.Views
{
    public partial class CategoryView : BView, IView
    {
        private CategoryController _controller;
        public CategoryView()
        {
            InitializeComponent();
            _controller = new CategoryController();
            Controller = _controller;
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
            CategoryDetailView view = new CategoryDetailView(_controller);
            return view;
        }

        protected override IDetailView CreateNewView()
        {
            NewCategoryView view = new NewCategoryView(_controller);
            return view;
        }
    }
}
