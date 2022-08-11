using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Pattern.Domain
{
    public class PersonalGymMembership : IMembership
    {
        private readonly string _name;
        private readonly decimal _price;

        public PersonalGymMembership(decimal price)
        {
            _name = "Personal gym membership";
            _price = price;
        }

        public string Name => _name;

        public string Description { get; set; }

        public decimal GetPrice() => _price;
    }
}
