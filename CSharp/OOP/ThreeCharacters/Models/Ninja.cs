using System;
using System.Collections.Generic;

namespace ThreeCharacters.Models
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            base.Dexterity = 175;
        }

        public Ninja(string name, int str, int intel, int dex, int hp) : base(name, str, intel, dex, hp)
        {

        }

        public override int Attack(Human target)
        {
            if (target is Human)
            {
                Random rand = new Random();
                int dmg = 5 * Dexterity;
                if (rand.Next(0, 6) == 2)
                {
                    dmg += 10;
                }
                target.Health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.Health;
            } 
            else
            {
                Console.WriteLine("Wrong Target!!");
                return target.Health;
            }
        }

        public void Steal(Human target)
        {
            target.Health -= 5;
            health += 5;
        }

    }
}