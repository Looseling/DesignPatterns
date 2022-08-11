using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    public class Watergun : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("attacks with water gun");
        }
    }
}
