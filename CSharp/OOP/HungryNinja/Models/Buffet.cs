using System;
using System.Collections.Generic;

namespace HungryNinja.Models
{
    class Buffet
    {
        public List<IConsumable> Menu;
         
        //constructor
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Burger", 240, false, false),
                new Food("Salad", 80, false, false),
                new Food("Pizza", 300, false, false),
                new Food("Poke", 160, true, true),
                new Food("PadThai", 120, true, true),
                new Food("Tomyum", 100, true, false),
                new Drink("Orange Juice", 60),
                new Drink("Chocolate Smoothy", 80),
                new Drink("Milk Tea", 70),
                new Drink("Vodga", 40),
                new Drink("Soju", 30)
            };
        }
         
        public IConsumable Serve()
        {
            Random rand = new Random();
            int index = rand.Next(0, 7);
            return Menu[index];
        }
    }

}