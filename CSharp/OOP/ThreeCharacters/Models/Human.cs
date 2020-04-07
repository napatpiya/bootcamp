using System;

namespace ThreeCharacters.Models
{
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
         
        // add a public "getter" property to access health
        public int Health
        {
            get { return health; }
        }
         
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
         
        // Add a constructor to assign custom values to all fields
        public Human(string name, int str, int intel, int dex)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = 100;
        }
         
        // Build Attack method
        public int Attack(Human target)
        {
            if (target is Human)
            {
                int dmg = 5 * Strength;
                target.health -= dmg;
                return target.health;
            } 
            else
            {
                Console.WriteLine("Wrong Target!!");
                return target.health;
            }
        }
    }

}