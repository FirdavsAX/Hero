using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    internal class Lion : Heroes
    {
        public const int NormalHealth = 3_000;
        public Lion(int attackStrength,int speed,int health)
            : base("Lion",attackStrength,speed,health)
        {

        }
        public override void Run()
        {
            if(Health < NormalHealth)
            {
                Console.WriteLine($"{Name} is running with speed {0.6 * Speed}");
            }
            else
            {
                base.Run();
            }
        }
    }
}
