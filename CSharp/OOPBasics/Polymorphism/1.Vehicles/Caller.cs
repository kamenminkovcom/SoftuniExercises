namespace Vehicles
{
    public static class Caller
    {
        public static string CallMethod(string[] info, Vehicle vehicle)
        {
            string methodName = info[0];
            double param = double.Parse(info[2]);

            return vehicle.GetType().GetMethod(methodName).Invoke(vehicle,new object[]{param}).ToString();
        }
    }
}
