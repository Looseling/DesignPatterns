using System;
using Strategy.Strategies;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new("Squidward");
            hero.Attack();

            hero.SetWeapon(new Broom());

            hero.Attack();


        }
    }
}
