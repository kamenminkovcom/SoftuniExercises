﻿namespace Vehicles
{
    public static class Factory
    {
        public static Vehicle CreateInstance(string[] info)
        {
            string type = info[0];
            double fuelQuantity = double.Parse(info[1]);
            double fuelConsumption = double.Parse(info[2]);
            double tankCapacity = double.Parse(info[3]);

            switch (type)
            {
                case "Car":
                    return new Car(fuelQuantity, fuelConsumption, tankCapacity);
                case "Truck":
                    return new Truck(fuelQuantity, fuelConsumption, tankCapacity);
                case "Bus":
                    return new Bus(fuelQuantity, fuelConsumption, tankCapacity);
                default:
                    return null;
            }
        }
    }
}
