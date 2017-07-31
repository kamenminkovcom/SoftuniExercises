using System;
using System.Linq;
using System.Reflection;

namespace EnumsAndAttributes
{
    class StartUp
    {
        static void Main()
        {
            string command = Console.ReadLine();
            Type type = Assembly.GetExecutingAssembly().GetTypes().First(x => x.Name == string.Join("", command.Split(' ')));
            var method = typeof(Engine).GetMethod("GetCards");
            method.MakeGenericMethod(type).Invoke(new Engine(new ConsoleLogger()), new object[] { command });
        }
    }
}
