using System;
using System.Text;

public abstract class Provider : MineWorker
{
    private double energyOutput;

    protected Provider(string id, double energyOutput)
        : base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get => energyOutput;
        protected set
        {
            if (value < 0 || value >= 10000)
                throw new ArgumentException("AAAAAAAAAAAAAAAAAAA");
            energyOutput = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{GetType().Name.Replace("Provider", " Provider")} - {Id}");
        sb.Append($"Energy Output: {EnergyOutput}");
        return sb.ToString();
    }
}

