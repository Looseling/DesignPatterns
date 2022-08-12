using System.Collections.Generic;

namespace ProxyPattern
{
    public interface IChief
    {
        IEnumerable<Order> GetOrders();
        IDictionary<int, string> GetStatuses();
    }
}