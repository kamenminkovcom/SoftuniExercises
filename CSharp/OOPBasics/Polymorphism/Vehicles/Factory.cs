namespace Vehicles
{
    public static class Factory
    {
        public static Vehicle CreateInstance(string[] info)
        {
            string type = info[0];
            double fuelQuantity = double.Parse(info[1]);
            double fuelConsumption = double.Parse(info[2]);

            switch (type)
            {
                case "Car":
                    return new Car(fuelQuantity, fuelConsumption);
                case "Truck":
                    return new Truck(fuelQuantity, fuelConsumption);
                default:
                    return null;
            }
        }
    }
}
