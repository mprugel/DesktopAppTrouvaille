using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopAppTrouvaille.Controllers;

namespace DesktopAppTrouvaille.Views
{
    public partial class OrderViewUC : UserControl, IView
    {
        private OrderController controller;
        public OrderViewUC()
        {
            controller = new OrderController();

            InitializeComponent();
            listViewTemplate1.Controller = controller;
            controller.AttachView(this);
            controller.AttachView(listViewTemplate1);

            listViewTemplate1.AddColumn("Datum");
            listViewTemplate1.AddColumn("Status");
            listViewTemplate1.UpdateView();
        }

        public void UpdateView()
        {
            
        }
    }
}
