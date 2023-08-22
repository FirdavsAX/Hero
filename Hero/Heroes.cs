using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    internal class Heroes
    {
        public string Name { get; set; }
        public int AttackStrength { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public Heroes(string name, int attackStrength, int speed, int health)
        {
            Name = name;
            AttackStrength = attackStrength;
            Speed = speed;
            Health = health;
        }
        public virtual void Attack()
        {
            Console.WriteLine($"{Name} attacking with strength {AttackStrength}!");
        }
        public virtual void Run()
        {
            Console.WriteLine($"{Name} is running");
        }
        public virtual void Defend()
        {
            Console.WriteLine($"{Name} is defending");
        }
        public void Display()
        {
            Console.WriteLine($"Name {Name}");
            Console.WriteLine($"Attack strength {AttackStrength}");
            Console.WriteLine($"Speed {Speed}");
            Console.WriteLine($"Health {Health}");
            Console.WriteLine();
        }
    }
}
