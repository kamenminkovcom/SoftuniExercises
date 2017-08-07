namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;
    using System.Linq;
    using System.Reflection;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            Type type = Assembly.GetExecutingAssembly().GetTypes().First(x => x.Name == unitType);
            return Activator.CreateInstance(type) as IUnit;
        }
    }
}
