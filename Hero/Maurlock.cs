using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    internal class Maurlock : Heroes
    {
        public int NightAttack { get;private set; }
        public int NightSpeed { get;private set; }
        public Maurlock(int nightAttack, int nightSpeed,int attackStrength,int speed,int health)
            :base("Maurlock",attackStrength,speed,health)
        {
            NightAttack=nightAttack;
            NightSpeed=nightSpeed;
        }
        public override void Attack()
        {
            if(DateTime.Now.Hour > 18 || DateTime.Now.Hour < 6)
            {
                Console.WriteLine($"{Name} attacking with strength {NightAttack}");
            }
            else
            {
                base.Attack();
            }
        }
        public override void Run()
        {
            if (DateTime.Now.Hour > 18 || DateTime.Now.Hour < 6)
            {
                Console.WriteLine($"{Name} at runnnig with speed {NightSpeed}");
            }
            else
            {
                base.Run();
            }
        }
    }
}
