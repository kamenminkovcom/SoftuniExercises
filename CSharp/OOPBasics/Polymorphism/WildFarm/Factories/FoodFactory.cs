using System;
using System.Linq;

namespace WildFarm.Factories
{
    public static class FoodFactory
    {
        public static object CreateInstance(string[] info)
        {
            Type type = System.Reflection.Assembly.GetExecutingAssembly().GetTypes().First(x => x.Name == info[0]);
            return Activator.CreateInstance(type, new object[] { double.Parse(info[1]) });
        }
    }
}
