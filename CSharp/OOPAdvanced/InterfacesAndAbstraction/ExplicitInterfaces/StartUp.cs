using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                return;
            }
            string[] info = input.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            Citizen citizen = new Citizen(info[0], int.Parse(info[2]), info[1]);
            Console.WriteLine(citizen.ToString());
        }
    }
}

