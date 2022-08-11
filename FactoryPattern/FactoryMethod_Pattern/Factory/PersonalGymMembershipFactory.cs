using FactoryMethod_Pattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Pattern.Factory
{
    internal class PersonalGymMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _desc;

        public PersonalGymMembershipFactory(decimal price, string desc)
        {
            _price = price;
            _desc = desc;
        }
        public override IMembership GetMembership()
        {
            PersonalGymMembership membership = new(_price)
            {
                Description = _desc
            };

            return membership;
        }

    }
}
