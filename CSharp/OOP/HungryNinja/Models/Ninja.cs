using System;
using System.Collections.Generic;

namespace HungryNinja.Models
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
         
        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
         
        // add a public "getter" property called "IsFull"
        public bool IsFull
        {
            get
            {
                if (calorieIntake > 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
         
        // build out the Eat method
        public void Eat(Food item)
        {
            if (!IsFull)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"Food name: {item.Name}\nCalories: {item.Calories}");
                if (item.IsSpicy)
                {
                    Console.WriteLine("Taste: Spicy");
                }
                if (item.IsSweet)
                {
                    Console.WriteLine("Taste: Sweet");
                }
                Console.WriteLine($"Calorie in take: {calorieIntake}");
            }
            else
            {
                Console.WriteLine("the ninja is full and cannot eat anymore");
                Console.WriteLine($"Calorie in take: {calorieIntake}");
            }
        }
    }

}