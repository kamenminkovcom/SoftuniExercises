using WildFarm.FoodClasses;

namespace WildFarm.AnimalClasses
{
    public abstract class Felime : Mammal
    {
        public Felime(string name, double weight, string livingRegion) : base (name, weight, livingRegion)
        {}

        public override void Eat(Food food)
        {
            this.Food = food.Quantity;
        }
    }
}
