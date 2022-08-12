using Builder.Burgers;
using System;

namespace Builder.BurgerBuilders
{
    public class WhopperBuilder :  IBurgerBuilder<Whopper>
    {
        private Whopper BM;

        public WhopperBuilder()
        {
            BM = new();
        }

        public IBurgerBuilder<Whopper> AddBun()
        {
            BM.Bun = true;
            return this;
        }

        public IBurgerBuilder<Whopper> AddPatty()
        {
            BM.PattyCow = true; 
            return this;
        }

        public IBurgerBuilder<Whopper> AddKetchup()
        {
            BM.Ketchup = true; 
            return this;
        }

        public IBurgerBuilder<Whopper> AddMayo()
        {
            BM.Mayo = true; 
            return this;
        }
        public IBurgerBuilder<Whopper> AddPickle()
        {
            BM.Pickle = true; 
            return this;
        }
        public IBurgerBuilder<Whopper> Salad()
        {
            BM.Salad = true;
            return this;
        }

        public IBurgerBuilder<Whopper> AddTomato()
        {
            BM.Tomato = true;
            return this;
        }
        public Whopper Build()
        {
            Console.WriteLine("Your Whopper is ready, it has: ");
            Console.WriteLine($"{BM.Bun}: Bun");
            Console.WriteLine($"{BM.Tomato}: Tomato");
            Console.WriteLine($"{BM.Salad}: Salad");
            Console.WriteLine($"{BM.Ketchup}: Ketchup");
            Console.WriteLine($"{BM.Mayo}: Mayo");
            Console.WriteLine($"{BM.Pickle}: Pickle");
            Console.WriteLine($"{BM.PattyCow}: PattyCow");

            return BM;
        }

        public void reset()
        {
            BM = new();
        }
    }
}
