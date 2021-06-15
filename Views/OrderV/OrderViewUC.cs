using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Factories;
using DesktopAppTrouvaille.Views.FilterV;

namespace DesktopAppTrouvaille.Views
{
    public partial class OrderViewUC : BView, IView
    {
        private OrderController controller;
        
        public OrderViewUC(OrderController cont)
        {
            controller = cont;
            Controller = cont;
            InitializeComponent();
            Controller.AttachView(this);
            Controller.AttachView(listView);
            listView.Controller = Controller;
            listView.Factory = new OrderItemFactory();
            listView.FilterView = new OrderFilter(controller);
            listView.Init();

            controller.UpdateData();
        }
        public OrderViewUC()
        {
            InitializeComponent();
        }

            public void UpdateView()
        {
            UpdateStatusLabel();
        }

        protected override IDetailView CreateDetailView(IModel model)
        {
            OrderDetailView view = new OrderDetailView();
            view.Controller = controller;
            return view;
        }
    }
}
