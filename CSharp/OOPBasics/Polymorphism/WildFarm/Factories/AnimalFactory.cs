using System;
using System.Linq;
using WildFarm.AnimalClasses;

namespace WildFarm.Factories
{
    public static class AnimalFactory
    {
        public static object CreateInstance(string[] animalInfo)
        {
            Type type = System.Reflection.Assembly.GetExecutingAssembly().GetTypes().First(x => x.Name == animalInfo[0]);
            string name = animalInfo[1];
            double weight = double.Parse(animalInfo[2]);
            string livingRegion = animalInfo[3];

            if (type == typeof(Cat))
            {
                return Activator.CreateInstance(type, new Object[] { name, weight, livingRegion, animalInfo[4] });
            }

            return Activator.CreateInstance(type, new Object[] { name, weight, livingRegion });
        }
    }
}
