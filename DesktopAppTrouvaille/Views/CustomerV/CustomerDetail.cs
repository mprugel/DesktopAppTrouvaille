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
using DesktopAppTrouvaille.Models;

namespace DesktopAppTrouvaille.Views
{
    public partial class CustomerDetail : UserControl, IDetailView
    {
        public CustomerController Controller;
        public Category category;
        public CustomerDetail()
        {
            InitializeComponent();
        }

        public void SetController(IController controller)
        {
            Controller = (CustomerController)controller;
        }

        public void SetModel(IModel model)
        {
            category = (Category)model;
        }

        public void UpdateView()
        {
            
        }
    }
}
