using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;

        public Vehicle(double fuelQuantity, double fuelConsumption, double airConditionerFactor, double tankSpecificFactor)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.AirConditionerFactor = airConditionerFactor;
            this.TankSpecificFactor = tankSpecificFactor;
        }

        public double AirConditionerFactor { get; }
        public double TankSpecificFactor { get;  }

        public double FuelQuantity
        {
            get => fuelQuantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Fuel Quntity should be positive number.");
                fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get => fuelConsumption;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Fuel Consumption should be positive number.");
                fuelConsumption = value;
            }
        }

        public string Drive(double kilometers)
        {
            double fuelNeeded = kilometers * (FuelConsumption + AirConditionerFactor);

            if (fuelNeeded > FuelQuantity)
                return $"{GetType().Name} needs refueling";
            FuelQuantity -= fuelNeeded;
            return $"{GetType().Name} travelled {kilometers} km";
        }

        public string Refuel(double quantity)
        {
            FuelQuantity += quantity * TankSpecificFactor;
            return $"{GetType().Name}: {FuelQuantity:f2}";
        }

        public override string ToString() => $"{GetType().Name}: {FuelQuantity:f2}";
    }
}
