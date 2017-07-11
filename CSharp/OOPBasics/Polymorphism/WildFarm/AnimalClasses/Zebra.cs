using System;

namespace WildFarm.AnimalClasses
{
    public class Zebra : Mammal
    {
        public Zebra(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        { }

        public override void MakeSound()
        {
            Console.WriteLine("Zs");   
        }
    }
}
