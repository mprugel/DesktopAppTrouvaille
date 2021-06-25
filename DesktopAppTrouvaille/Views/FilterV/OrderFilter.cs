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
        private OrderCriteria _criteria = new OrderCriteria();

        public OrderCriteria GetFilterCriteria()
        {
            
            _criteria.OrderDateFrom = dateTimePickerFrom.Value;
            _criteria.OrderDateTo = dateTimePickerTo.Value;

            if(Guid.TryParse(textBox1.Text, out _criteria.CustomerGuid))
            {
                _criteria.FilerID = true;
            }
            else
            {
                _criteria.FilerID = false;
            }

            _criteria.OrderState = ((KeyValuePair<OrderState,string>)comboBoxState.SelectedItem).Key;
            Console.WriteLine("Selected State: " + _criteria.OrderState);
            return _criteria;
        }

        public override void UpdateView()
        {
            comboBoxState.DataSource = new BindingSource(OrderStateDic,null);
            comboBoxState.DisplayMember = "Value";
            comboBoxState.ValueMember = "Key";

            textBox1.Text = Controller.GetFilter().CustomerGuid.ToString();
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

        private void checkBoxDate_CheckedChanged(object sender, EventArgs e)
        {
            _criteria.FilterDate = checkBoxDate.Checked;
        }

        private void checkBoxState_CheckedChanged(object sender, EventArgs e)
        {
            _criteria.FilterState = checkBoxState.Checked;
        }
    }
}
