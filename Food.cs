namespace Hungry_Ninja{
    public class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet; 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string inputName, int inputCalories, bool inputIsSpicy, bool inputIsSweet)
        {
            Name = inputName;
            Calories = inputCalories;
            IsSpicy = inputIsSpicy;
            IsSweet = inputIsSweet;
        }
   }
}


