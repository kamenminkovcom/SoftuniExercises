using System;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private double fuelQuantity;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption,tankCapacity, 1.6, 0.95)
        { }

        public override double FuelQuantity
        {
            get => fuelQuantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Fuel must be positive number.");
                fuelQuantity = value;
            }
        }
    }
}
