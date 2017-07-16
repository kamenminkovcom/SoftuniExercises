using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class ProviderFactory : Factory
{
    public override MineWorker CreateInstance(List<string> args)
    {
        Type classType = Assembly.GetExecutingAssembly().GetTypes().First(x => x.Name == args[0] + "Provider");
        return Activator.CreateInstance(classType, args[1], double.Parse(args[2])) as Provider;
    }
}