using Builder.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BurgerBuilders
{
    public class CrispyChikenBuilder : CrispyChiken, IBurgerBuilder<CrispyChiken>
    {
        private CrispyChiken BM;

        public CrispyChikenBuilder()
        {
            BM = new();
            
        }


        public IBurgerBuilder<CrispyChiken> AddBun()
        {
            BM.Bun = true;
            return this;
        }

        public IBurgerBuilder<CrispyChiken> AddPatty()
        {
            BM.PattyChicken = true;
            return this;
        }

        public IBurgerBuilder<CrispyChiken> AddKetchup()
        {
            BM.Ketchup = true;
            return this;
        }

        public IBurgerBuilder<CrispyChiken> AddCheese()
        {
            BM.Cheese = true;
            return this;
        }

        public CrispyChiken Build()
        {
            Console.WriteLine("Your Crispy Chicken is ready, it has: ");
            Console.WriteLine($"{BM.Bun}: Bun");
            Console.WriteLine($"{BM.Cheese}: Cheese");
            Console.WriteLine($"{BM.PattyChicken}: PattyChicken");
            Console.WriteLine($"{BM.Ketchup}: Ketchup");

            return BM;
        }

        public void reset()
        {
            BM = new();
        }
    }
}
