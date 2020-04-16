using System;
using System.ComponentModel.DataAnnotations;

namespace Dojodachi.Models
{
    public class Dachi
    {
        public int Happiness { get; set; }
        public int Fullness { get; set; }
        public int Energy { get; set; }
        public int Meals { get; set; }
        public string Comment { get; set; }
        public bool IsWin { get; set; }
        public bool IsDead { get; set; }
        Random rand = new Random();

        public Dachi()
        {
            Happiness = 20;
            Fullness = 20;
            Energy = 50;
            Meals = 3;
            Comment = "Let's get started!";
            IsWin = false;
            IsDead = false;
        }

        public Dachi Feed(Dachi dachi)
        {
            
            if ( dachi.Meals < 1 )
            {
                dachi.Comment = "You cannot feeding! Your meal is empty.";
                return dachi;
            }
            else
            {
                dachi.Meals--;
                int fullnessInc = rand.Next(5, 11);
                dachi.Fullness += fullnessInc;
                dachi.Comment = $"Dachi -> Fullness +{fullnessInc}, Meal -1";
                return dachi;
            }
        }

        public Dachi Play(Dachi dachi)
        {
            if ( dachi.Energy < 5 )
            {
                dachi.Comment = "";
                return dachi;
            }
            else
            {
                dachi.Energy -= 5;
                int happinessInc = rand.Next(5, 11);
                dachi.Comment = $"Dachi -> Happiness +{happinessInc}, Energy -5";
                return dachi;
            }
        }

        public Dachi Work(Dachi dachi)
        {
            if ( dachi.Energy < 5 )
            {
                dachi.Comment = "";
                return dachi;
            }
            else
            {
                dachi.Energy -= 5;
                int mealsInc = rand.Next(1, 4);
                dachi.Comment = $"Dachi -> Meals +{mealsInc}, Energy -5";
                return dachi;
            }
        }

        public Dachi Sleep(Dachi dachi)
        {
            dachi.Happiness -= 5;
            dachi.Fullness -= 5;
            dachi.Energy += 15;
            dachi.Comment = $"Dachi -> Energy +15, Happiness -5, Fullness -5";
            return dachi;
        }

        public Dachi CheckStatus(Dachi dachi)
        {
            if ( dachi.Energy > 100 && dachi.Fullness > 100 && dachi.Happiness > 100 )
            {
                dachi.IsWin = true;
                dachi.Comment = "You WIN!";
                return dachi;
            }
            else 
            {
                if ( dachi.Fullness < 0 || dachi.Happiness < 0)
                {
                    dachi.IsDead = true;
                    dachi.Comment = "You LOSE!";
                    return dachi;
                }
            }

            return dachi;
        }
    }
}