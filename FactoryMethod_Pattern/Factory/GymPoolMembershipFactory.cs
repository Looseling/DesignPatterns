using FactoryMethod_Pattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Pattern.Factory
{
    internal class GymPoolMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _desc;

        public GymPoolMembershipFactory(decimal price, string desc)
        {
            _price = price;
            _desc = desc;
        }
        public override IMembership GetMembership()
        {
            GymPoolMembership membership = new(_price)
            {
                Description = _desc
            };

            return membership;
        }
    }
}
