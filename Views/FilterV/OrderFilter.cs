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
using DesktopAppTrouvaille.FilterCriterias;
using static DesktopAppTrouvaille.Globals.Globals;

namespace DesktopAppTrouvaille.Views.FilterV
{
    public partial class OrderFilter : UserControl, IView
    {
        public OrderController Controller;

        public OrderCriteria GetFilterCriteria()
        {
            OrderCriteria criteria = new OrderCriteria();
            criteria.OrderDate = dateTimePicker1.Value;
            criteria.OrderState = ((KeyValuePair<OrderState,string>)comboBoxState.SelectedItem).Key;
            Console.WriteLine("Selected State: " + criteria.OrderState);
            return criteria;
        }

        public void UpdateView()
        {
            comboBoxState.DataSource = new BindingSource(OrderStateDic,null);
            comboBoxState.DisplayMember = "Value";
            comboBoxState.ValueMember = "Key";
        }

        public OrderFilter(OrderController controller = null)
        {
            InitializeComponent();
            Controller = controller;
            UpdateView();
        }

        private void comboBoxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetFilterCriteria();
        }
    }
}
