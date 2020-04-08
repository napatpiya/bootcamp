using System;
using System.Collections.Generic;

namespace ThreeCharacters.Models
{
    public class Wizard : Human
    {

        public Wizard(string name) : base(name)
        {
            base.Intelligence = 25;
            base.health = 50;
        }

        public Wizard(string name, int str, int intel, int dex, int hp) : base(name, str, intel, dex, hp)
        {

        }

        public override int Attack(Human target)
        {
            if (target is Human)
            {
                int dmg = 5 * Intelligence;
                target.Health -= dmg;
                health += dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.Health;
            } 
            else
            {
                Console.WriteLine("Wrong Target!!");
                return target.Health;
            }
        }

        public void Heal(Human target)
        {
            target.Health += 10 * Intelligence;
        }

    }
}