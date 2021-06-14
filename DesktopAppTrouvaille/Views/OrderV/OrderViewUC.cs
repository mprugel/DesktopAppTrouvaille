using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Factories;
using DesktopAppTrouvaille.Views.FilterV;

namespace DesktopAppTrouvaille.Views
{
    public partial class OrderViewUC : BView, IView
    {
        private OrderController _controller;
        public OrderViewUC()
        {
            InitializeComponent();
            _controller = new OrderController();
            Controller = _controller;
            Controller.AttachView(this);
            Controller.AttachView(listView);
            listView.Controller = Controller;
            listView.Factory = new OrderItemFactory();
            listView.FilterView = new OrderFilter(_controller);
            listView.Init();

            _controller.UpdateData();
        }

        public void UpdateView()
        {
            UpdateStatusLabel();
        }

        protected override IDetailView CreateDetailView(IModel model)
        {
            OrderDetailView view = new OrderDetailView();
            view.Controller = _controller;
            return view;
        }
    }
}
