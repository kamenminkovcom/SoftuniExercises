namespace EnumsAndAttributes
{
    using System;

    public class Engine
    {
        public Engine(ILogger logger)
        {
            this.Logger = logger;
        }

        public ILogger Logger { get; }

        public void GetCards<T>(string command)
        {
            var iterator = new Iterator<T>();
            Logger.Log(command + ":");
            foreach (var element in iterator.GetValues())
            {
                Console.WriteLine($"Ordinal value: {Convert.ToInt32(element)}; Name value: {element}");
            }
        }
    }
}
