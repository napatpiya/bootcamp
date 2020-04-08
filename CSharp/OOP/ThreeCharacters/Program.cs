using System;
using ThreeCharacters.Models;

namespace ThreeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Human bill = new Human("Billy");
            Human bob = new Human("Bobby", 8, 4, 7, 100);
            bill.Attack(bob);
            bob.DisplayStat();
            Wizard w1 = new Wizard("Will");
            w1.DisplayStat();
            Console.WriteLine("############");
            Ninja n1 = new Ninja("Aon");
            n1.DisplayStat();
            Console.WriteLine("############");
            Samurai s1 = new Samurai("Panajon");
            s1.DisplayStat();
            Console.WriteLine("############");

            Wizard w2 = new Wizard("Mike");
            n1.DisplayStat();
            n1.Attack(s1);
            s1.DisplayStat();
            s1.Meditate();
            s1.DisplayStat();
        }
    }
}
