using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ProxyPattern
{
    //Remote Proxy  
    //Virtual Proxy 
    //Protection Proxy 
    //Smart Reference Proxy

    internal class Program
    {
        static void Main(string[] args)
        {
         IChief chief = new ChiefProxy(new Chief());

            while (true)
            {
                Thread.Sleep(2000);

                Console.Clear();

                Console.WriteLine("WElcome to Cooker! \n");
                Console.WriteLine("========== Orders =========");

                IEnumerable<Order> orders = chief.GetOrders();
                
                foreach (var order in orders)
                {
                    string status = chief.GetStatuses().First(s => s.Key == order.StatusId).Value;

                    Console.WriteLine($"{order.Name}\t\t{status}");
                }
            }
        }
    }
}
