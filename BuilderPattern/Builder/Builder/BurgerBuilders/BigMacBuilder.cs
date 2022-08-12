using Builder.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BurgerBuilders
{
    public class BigMacBuilder : BigMac, IBurgerBuilder<BigMac>
    {
        private BigMac BM;

        public BigMacBuilder()
        {
            BM = new();
        }


        public IBurgerBuilder<BigMac> AddBun()
        {
            BM.Bun = true;
            return this;
        }

        public IBurgerBuilder<BigMac> AddPatty()
        {
            BM.PattyPork = true;
            return this;

        }

        public IBurgerBuilder<BigMac> AddPickles()
        {
            BM.Pickle = true;
            return this;
        }

        public IBurgerBuilder<BigMac> AddKetchup()
        {
            BM.Ketchup = true;
            return this;
        }
        public IBurgerBuilder<BigMac> AddMayo()
        {
            BM.Mayo= true;
            return this;
        }

        public BigMac Build()
        {
            Console.WriteLine("Your BigMac is ready, it has: ");
            Console.WriteLine($"{BM.Bun}: Bun");
            Console.WriteLine($"{BM.Mayo}: Mayo");
            Console.WriteLine($"{BM.PattyPork}: PattyPork");
            Console.WriteLine($"{BM.Pickle}: Pickle");
            Console.WriteLine($"{BM.Ketchup}: Ketchup");


            return BM;
        }

        public void reset()
        {
            BM = new();
        }
    }
}
