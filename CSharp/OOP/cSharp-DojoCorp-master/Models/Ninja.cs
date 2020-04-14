using System;

namespace cSharp_DojoCorp.Models
{
    public class Ninja : Hero
    {
        public override void SayName()
        {
            Console.WriteLine($"Hello My name is {Name}, and I'm a ninja.");
        }

        public Ninja(string name) : base(name){}
    }
}