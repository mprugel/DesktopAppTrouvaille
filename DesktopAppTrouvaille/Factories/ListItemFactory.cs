﻿using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopAppTrouvaille.Factories
{
    public abstract class ListItemFactory
    {
        public List<ListViewItem> CreateListViewItems(IEnumerable<IModel> models)
        {
            List<ListViewItem> list = new List<ListViewItem>();
            foreach (IModel p in models)
            {
                list.Add(CreateListViewItem(p));
            }
            return list;
        }

        private ListViewItem CreateListViewItem(IModel model)
        {
            string[] stringItems = CreateRowValues(model);
            ListViewItem item = new ListViewItem(stringItems, 1);
            item.Tag = model;
            return item;
        }
        public abstract string[] CreateColumns();
        protected abstract string[] CreateRowValues(IModel model);
        
    }
}
