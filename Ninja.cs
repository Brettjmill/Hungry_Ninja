using System;
using System.Collections.Generic;

namespace Hungry_Ninja{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
         
        public void EmptyStomach()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        public bool IsFull()
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
         
        // build out the Eat method
        public void Eat(Food item)
        {
            if (IsFull() != true)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"You ate {item.Name}.  Spicy: {item.IsSpicy}, Sweet: {item.IsSweet}.");
            }
            else
            {
                Console.WriteLine("THIS NINJA IS TOO FULL TO EAT!");
            }
        }
    }
}