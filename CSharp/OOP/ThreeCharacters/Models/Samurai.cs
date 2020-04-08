using System;
using System.Collections.Generic;

namespace ThreeCharacters.Models
{
    public class Samurai : Human
    {
    public Samurai(string name) : base(name)
        {
            base.health = 200;
        }

        public Samurai(string name, int str, int intel, int dex, int hp) : base(name, str, intel, dex, hp)
        {

        }

        public override int Attack(Human target)
        {
            if (target is Human)
            {
                base.Attack(target);
                if (target.Health < 50)
                {
                    target.Health = 0;
                }
                Console.WriteLine($"{Name} attacked {target.Name}");
                return target.Health;
            } 
            else
            {
                Console.WriteLine("Wrong Target!!");
                return target.Health;
            }
        }

        public void Meditate()
        {
            health = 200;
        }

    }
}