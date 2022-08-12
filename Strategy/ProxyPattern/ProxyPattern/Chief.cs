using System;
using System.Collections.Generic;
using System.Threading;

namespace ProxyPattern
{
    public class Chief : IChief
    {
        public IDictionary<int, string> GetStatuses()
        {
            Dictionary<int, string> statuses = new();

            statuses.Add(1, "ready");
            statuses.Add(2, "not ready");
            statuses.Add(3, "preparing");

            Thread.Sleep(2000);

            return statuses;
        }

        public IEnumerable<Order> GetOrders()
        {
            List<Order> order = new List<Order>();

            order.Add(new Order() { Name = "Burger", StatusId = Random() });
            order.Add(new Order() { Name = "Pasta", StatusId = Random() });
            order.Add(new Order() { Name = "Omlet", StatusId = Random() });
            order.Add(new Order() { Name = "Sushi", StatusId = Random() });

            return order;
        }

        private static int Random()
        {
            return new Random().Next(1, 4);
        }


    }
}
