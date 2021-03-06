﻿using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity, double airConditionerFactor, double tankSpecificFactor)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            AirConditionerFactor = airConditionerFactor;
            TankSpecificFactor = tankSpecificFactor;
        }

        public double AirConditionerFactor { get; set; }
        public double TankSpecificFactor { get; }

        public virtual double FuelQuantity
        {
            get => fuelQuantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Fuel must be positive number.");
                if (value > tankCapacity)
                    throw new ArgumentException("Cannot fit fuel in tank.");
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

        public double TankCapacity
        {
            get => tankCapacity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Tank capacity must be positive number.");
                tankCapacity = value;
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
            if (quantity <= 0)
                throw new ArgumentException("Fuel must be positive number.");
            FuelQuantity += quantity * TankSpecificFactor;
            return $"{GetType().Name}: {FuelQuantity:f2}";
        }

        public override string ToString() => $"{GetType().Name}: {FuelQuantity:f2}";
    }
}
