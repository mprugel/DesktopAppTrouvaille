using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAppTrouvaille.Models;
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.Factories;

namespace DesktopAppTrouvaille.Views.EmployeeV 
{
    public partial class EmployeeView : BView, IView
    {
        EmployeeController _controller;
        public EmployeeView()
        {
            InitializeComponent();
        }
        public EmployeeView(EmployeeController controller)
        {
            InitializeComponent();
            _controller = controller;
            Controller = _controller;

            Controller.AttachView(this);
            Controller.AttachView(listView);
            listView.Controller = Controller;
            listView.Factory = new EmployeeFactory();
            

            listView.Init();
        }

        public void UpdateView()
        {
            UpdateStatusLabel();
        }

        protected override IDetailView CreateDetailView(IModel model)
        {
            EmployeeDetailView view = new EmployeeDetailView(_controller);
            return view;
        }

        protected override IDetailView CreateNewView()
        {
            return new NewEmployeeView(_controller);
        }
    }
}
