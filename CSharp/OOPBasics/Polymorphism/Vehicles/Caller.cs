using System;

namespace Vehicles
{
    public static class Caller
    {
        public static string CallMethod(string[] info, Vehicle vehicle)
        {
            string methodName = info[0];
            double param = double.Parse(info[2]);
            string result = null;
            try
            {
                result = vehicle.GetType().GetMethod(methodName).Invoke(vehicle, new object[] { param }).ToString();
            }
            catch (Exception e)
            {
                return e.InnerException.Message;
            }
            return result;
        }
    }
}
