using System;
using WildFarm.FoodClasses;

namespace WildFarm.AnimalClasses
{
    public class Tiger : Felime
    {
        public Tiger(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        { }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Vegetable")
                throw new ArgumentException($"{GetType().Name}s are not eating that type of food.");
            Food = food.Quantity;
        }
    }
}
