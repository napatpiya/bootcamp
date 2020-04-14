using System;
using cSharp_DojoCorp.Models;

namespace cSharp_DojoCorp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleCyan("********DOJO CORP********");

            Hero player = PlayerSetup();
            
            ConsoleCyan($"Congratulations {player.Name}!!! You have landed your first job after graduation and are excited to hit the ground running to show your new team that you know what you are doing.\n\nAfter some brief introductions and HR nonsense, you quickly realize that you must work hard to complete everything that your new boss is throwing at you.  From TPS reports and spreedsheets to making sure you make that meeting on time, you need to keep on top of your work or you will be terminiated.  Will you survive your first day!?!\n\nPress Enter to Start");

            ConsoleKey key  = Console.ReadKey(true).Key;
            while(key != ConsoleKey.Enter)
            {
                key  = Console.ReadKey(true).Key;
            }
            Console.WriteLine("BEGIN YOUR ADVENTURE HERE!!!");

            //write a method that will create other team mates.

            // make a game(while) loop to run your game
        }

        static void ConsoleCyan(string text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static Hero PlayerSetup()
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();
            string choice = "0";

            while( choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("Please type the number of the hero you would ike to be?\n1. Ninja\n2. Wizard\n3. Sensei");
                choice = Console.ReadLine();
            }

            switch (choice)
            {
                case("1"):
                    Ninja ninjaHero = new Ninja(name);
                    return ninjaHero;
                case("2"):
                    // Change Ninja to another class of hero.
                    Ninja wizardHero = new Ninja(name);
                    return wizardHero;
                case("3"):
                    // Change Ninja to another class of hero.
                    Ninja senseiHero = new Ninja(name);
                    return senseiHero;
            }
            return null;
        }
    }
}
