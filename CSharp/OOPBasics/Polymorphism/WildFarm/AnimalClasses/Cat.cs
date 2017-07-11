using System;

namespace WildFarm.AnimalClasses
{
    public class Cat : Felime
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override string ToString() =>
            $"{GetType().Name}[{Name}, {Breed}, {Weight}, {LivingRegion}, {Food}]";
    }
}
