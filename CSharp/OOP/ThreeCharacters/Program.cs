using System;
using ThreeCharacters.Models;

namespace ThreeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Human bill = new Human("Billy");
            Console.WriteLine($"Name: {bill.Name}\nStrength: {bill.Strength}\nIntelligence: {bill.Intelligence}\nDexterity: {bill.Dexterity}\nHealth: {bill.Health}");
            Human bob = new Human("Bobby", 8, 4, 7);
            Console.WriteLine($"Name: {bob.Name}\nStrength: {bob.Strength}\nIntelligence: {bob.Intelligence}\nDexterity: {bob.Dexterity}\nHealth: {bob.Health}");
            bill.Attack(bob);
            Console.WriteLine($"Name: {bob.Name}\nStrength: {bob.Strength}\nIntelligence: {bob.Intelligence}\nDexterity: {bob.Dexterity}\nHealth: {bob.Health}");
        }
    }
}
