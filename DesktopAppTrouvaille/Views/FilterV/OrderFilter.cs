using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DesktopAppTrouvaille.Controllers;
using DesktopAppTrouvaille.FilterCriterias;
using static DesktopAppTrouvaille.Globals.Globals;

namespace DesktopAppTrouvaille.Views.FilterV
{
    public partial class OrderFilter : Filter, IView
    {
        public OrderController Controller;

        public OrderCriteria GetFilterCriteria()
        {
            OrderCriteria criteria = new OrderCriteria();
            criteria.OrderDateFrom = dateTimePickerFrom.Value;
            criteria.OrderDateTo = dateTimePickerFrom.Value;

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

        public override void SendFilterToController()
        {
            Controller.SetFilterCriteria(GetFilterCriteria());
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
