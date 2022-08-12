using Builder.BurgerBuilders;
using Builder.Burgers;
using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBurgerBuilder<Whopper> Whopper = new WhopperBuilder();

            Whopper.AddKetchup().AddBun().AddPatty().Build();





        }
    }
}
