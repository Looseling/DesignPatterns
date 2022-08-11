using FactoryMethod_Pattern.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Pattern.Factory
{
    internal abstract class MembershipFactory
    {
        public abstract IMembership GetMembership();


    }
}
