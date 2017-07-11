using System;
using WildFarm.FoodClasses;

namespace WildFarm.AnimalClasses
{
    public abstract class Animal
    {
        private string name;
        private double weight;

        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.Food = 0;
        }

        public string Name
        {
            get => name;
            set
            {
               if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("The name should not be empty.");
                name = value;
            }
        }

        public double Weight
        {
            get => weight;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Weight cannot be negative.");
                weight = value;
            }
        }

        public double Food { get; set; }

        public abstract void MakeSound();

        public abstract void Eat(Food food);
    }
}
