using System;
using System.Linq;

class StartUp
{
    private static DraftManager manager = new DraftManager();
    static void Main()
    {
        while (true)
        {
            string command = Console.ReadLine();
            string result = null;
            if (command == "Shutdown")
            {
                Console.WriteLine(manager.ShutDown());
                return;
            }
            if (command != "Day")
            {
                var commands = command.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries).ToList();
                string methodName = commands[0];
                commands.RemoveAt(0);
                result = typeof(DraftManager).GetMethod(methodName).Invoke(manager, new object[]{commands}).ToString();
                Console.WriteLine(result);
                continue;
            }
            result = typeof(DraftManager).GetMethod(command).Invoke(manager, new object[] {}).ToString();
            Console.WriteLine(result);
        }
    }
}

