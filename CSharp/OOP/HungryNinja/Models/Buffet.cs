using System;
using System.Collections.Generic;

namespace HungryNinja.Models
{
    class Buffet
    {
        public List<Food> Menu;
         
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Burger", 240, false, false),
                new Food("Salad", 80, false, false),
                new Food("Pizza", 300, false, false),
                new Food("Poke", 160, true, true),
                new Food("Orange Juice", 60, false, true),
                new Food("PadThai", 120, true, true),
                new Food("Tomyum", 100, true, false)
            };
        }
         
        public Food Serve()
        {
            Random rand = new Random();
            int index = rand.Next(0, 7);
            return Menu[index];
        }
    }

}