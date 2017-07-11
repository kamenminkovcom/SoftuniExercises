using System;
using WildFarm.FoodClasses;

namespace WildFarm.AnimalClasses
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; set; }

        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Meat")
                throw new ArgumentException($"{GetType().Name}s are not eating that type of food.");
            Food = food.Quantity;
        }

        public override string ToString() => $"{GetType().Name}[{Name}, {Weight}, {LivingRegion}, {Food}]";
    }
}
