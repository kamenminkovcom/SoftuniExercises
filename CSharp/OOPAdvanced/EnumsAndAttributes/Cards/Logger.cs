namespace EnumsAndAttributes
{
    using System;

    public class ConsoleLogger : ILogger
    {
        public void Log(string value)
        {
            Console.WriteLine(value);
        }
    }
}
