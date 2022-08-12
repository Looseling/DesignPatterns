using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; } 

        public int StatusId { get; set; }


    }
}
