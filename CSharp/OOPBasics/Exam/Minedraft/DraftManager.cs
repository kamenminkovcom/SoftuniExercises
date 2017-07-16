using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class DraftManager
{
    private Dictionary<string, Harvester> harvesters = new Dictionary<string, Harvester>();
    private Dictionary<string, Provider> providers = new Dictionary<string, Provider>();
    private string mode = "Full";
    private double energy = 0;
    private double oreMined = 0;
    private HarvesterFactory harvestFactory = new HarvesterFactory();
    private ProviderFactory providerFactory = new ProviderFactory();

    public string RegisterHarvester(List<string> arguments)
    {
        Type type = Assembly.GetExecutingAssembly().GetTypes().First(x => x.Name == arguments[0] + "Harvester");
        Harvester harvester;
        try
        {
            if (type.Name == "SonicHarvester")
            {
                harvester = harvestFactory.CreateInstance(arguments) as Harvester;
            }
            else
            {
                harvester = harvestFactory.CreateInstance(arguments) as Harvester;
            }
        }
        catch (Exception e)
        {
            string propName = e.InnerException.TargetSite.Name.Substring(4);
            return $"Harvester is not registered, because of it's {propName}";
        }
        harvesters[arguments[1]] = harvester;
        return $"Successfully registered {arguments[0]} Harvester - {arguments[1]}";
    }

    public string RegisterProvider(List<string> arguments)
    {
        Provider provider;
        try
        {
            provider = providerFactory.CreateInstance(arguments) as Provider;
        }
        catch (Exception e)
        {
            string propName = e.InnerException.TargetSite.Name.Substring(4);
            return $"Provider is not registered, because of it's {propName}";
        }
        providers[arguments[1]] = provider;
        return $"Successfully registered {arguments[0]} Provider - {arguments[1]}";
    }

    public string Day()
    {
        var currentEnergy = providers.Values.Select(x => x.EnergyOutput).Sum();
        var currentOreMined = oreMined;
        energy += currentEnergy;
        CalulateEnergy();
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"A day has passed.");
        sb.AppendLine($"Energy Provided: {currentEnergy}");
        sb.Append($"Plumbus Ore Mined: {Math.Abs(oreMined - currentOreMined)}");
        return sb.ToString();
    }

    public string Mode(List<string> arguments)
    {
        mode = arguments[0];
        return $"Successfully changed working mode to {mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        string id = arguments[0];
        if (harvesters.ContainsKey(id))
        {
            return harvesters[id].ToString();
        }
        else if (providers.ContainsKey(id))
        {
            return providers[id].ToString();
        }
        return $"No element found with id - {id}";
    }

    public string ShutDown()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"System Shutdown");
        sb.AppendLine($"Total Energy Stored: {energy}");
        sb.Append($"Total Mined Plumbus Ore: {oreMined}");
        return sb.ToString();
    }

    private void CalulateEnergy()
    {
        double neededEnergy = 0;
        double currentOreMined = 0;
        if (mode == "Full")
        {
            neededEnergy = harvesters.Values.Select(x => x.EnergyRequirement).Sum();
            currentOreMined = harvesters.Values.Select(x => x.OreOutput).Sum();
        }
        else if (mode == "Half")
        {
            neededEnergy = harvesters.Values.Select(x => x.EnergyRequirement * 0.6).Sum();
            currentOreMined = harvesters.Values.Select(x => x.OreOutput * 0.5).Sum();
        }
        if (neededEnergy <= energy)
        {
            energy -= neededEnergy;
            oreMined += currentOreMined;
        }
    }
}

