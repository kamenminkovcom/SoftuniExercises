using System;
using System.Text;


public abstract class Harvester : MineWorker
{
    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement)
        :base (id)
    {
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public double OreOutput
    {
        get => oreOutput;
        protected set
        {
            if (value < 0)
                throw new ArgumentException("Throw some exception");
            oreOutput = value;
        }
    }

    public virtual double EnergyRequirement
    {
        get => energyRequirement;
        protected set
        {
            if (value < 0 || value > 20000)
                throw new ArgumentException("Throw some exception");
            energyRequirement = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{GetType().Name.Replace("Harvester", " Harvester")} - {Id}");
        sb.AppendLine($"Ore Output: {OreOutput}");
        sb.Append($"Energy Requirement: {EnergyRequirement}");
        return sb.ToString();
    }
}

