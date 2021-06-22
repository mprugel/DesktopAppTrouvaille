using DesktopAppTrouvaille.Enums;
using DesktopAppTrouvaille.FilterCriterias;
using DesktopAppTrouvaille.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static DesktopAppTrouvaille.Globals.Globals;

namespace DesktopAppTrouvaille.Processors
{
    public interface IOrderProcessor
    {
        Task<int> GetCount();
        Task<List<Order>> LoadOrders(int from, int to);

        Task<bool> UpdateOrder(Guid guid, OrderState state);

        Task<bool> DeleteOrder(Guid guid);
        Task<List<Order>> GetOrdersFRomCustomer(int from, int to, Guid guid);
        Task<List<Order>> SearchOrders(int from, int to, OrderCriteria criteria, OrderSortCriteria sortCriteria, SortingOrder order);
    }
}
