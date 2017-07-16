using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class HarvesterFactory : Factory
{
    public override MineWorker CreateInstance(List<string> args)
    {
        Type classType = Assembly.GetExecutingAssembly().GetTypes().First(x => x.Name == args[0] + "Harvester");

        if (args.Count == 5)
        {
            return Activator.CreateInstance(classType, args[1], double.Parse(args[2]), double.Parse(args[3]),
                int.Parse(args[4])) as Harvester;
        }

        return Activator.CreateInstance(classType, args[1], double.Parse(args[2]), double.Parse(args[3])) as Harvester;
    }
}

