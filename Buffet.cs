using System;
using System.Collections.Generic;

namespace Hungry_Ninja{
    class Buffet
    {
        public List<Food> Menu;
         
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Garlic Fries", 750, false, false),
                new Food("Bread Rolls", 800, false, false),
                new Food("Lemon Pepper Chicken", 450, true, false),
                new Food("Prime Rib", 500, false, false),
                new Food("Grilled Salmon", 400, true, false),
                new Food("Ice Cream", 600, false, true),
                new Food("Angel Food Cake", 550, false, true)
            };
        }
         
        public Food Serve()
        {
            Random rand = new Random();
            int MenuItem = rand.Next(0,7);
            return Menu[MenuItem];
        }
    }
}