using System;

namespace HungryNinja.Models
{
    class SweetTooth : Ninja
    {
        // provide override for IsFull (Full at 1500 Calories)
        public override bool IsFull
        {
            get
            {
                if (calorieIntake > 1500)
                {
                    Console.WriteLine("SweetTooth is full and cannot eat anymore");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }
        public override void Consume(IConsumable item)
        {
            // provide override for Consume
            if (IsFull)
            {
                Console.WriteLine("SweetTooth is full and cannot eat anymore");
            }
            else
            {
                calorieIntake += item.Calories;
                ConsumptionHistory.Add(item);
                if (item.IsSweet)
                {
                    calorieIntake += 10;
                }
                
                Console.WriteLine(item.GetInfo());
                // Console.WriteLine($"Food name: {item.Name}\nCalories: {item.Calories}");
                // if (item.IsSpicy)
                // {
                //     Console.WriteLine("Taste: Spicy");
                // }
                // if (item.IsSweet)
                // {
                //     Console.WriteLine("Taste: Sweet");
                // }
                // Console.WriteLine($"Calorie in take: {calorieIntake}");
            }
        }
    }

}