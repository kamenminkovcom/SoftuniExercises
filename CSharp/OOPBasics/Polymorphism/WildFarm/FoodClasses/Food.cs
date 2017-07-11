using System;

namespace WildFarm.FoodClasses
{
    public abstract class Food
    {
        private double quantity;

        public Food(double quantity)
        {
            this.Quantity = quantity;
        }

        public double Quantity
        {
            get => quantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Quantity should be positive number.");
                quantity = value;
            }
        }
    }
}
