using System;

namespace Hungry_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet delishFoods = new Buffet();

            Ninja starvingNinja = new Ninja();

            starvingNinja.EmptyStomach();
            starvingNinja.Eat(delishFoods.Serve());
            starvingNinja.Eat(delishFoods.Serve());
            starvingNinja.Eat(delishFoods.Serve());
            starvingNinja.Eat(delishFoods.Serve());
        }
    }
}
