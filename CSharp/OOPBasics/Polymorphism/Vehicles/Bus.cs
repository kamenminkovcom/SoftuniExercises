namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity, 1.4, 1)
        { }

        public string DriveEmpty(double distance)
        {
            AirConditionerFactor = 0;
            var result = Drive(distance);
            AirConditionerFactor = 1.4;
            return result;
        }
    }
}
