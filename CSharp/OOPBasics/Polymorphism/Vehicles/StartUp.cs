using System;

namespace Vehicles
{
    class StartUp
    {
        static void Main()
        {
            var car = Factory.CreateInstance(Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries));
            var truck = Factory.CreateInstance(Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries));
            int numberOfOperations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] info = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                string result = null;
                switch (info[1])
                {
                    case "Car":
                        result = Caller.CallMethod(info, car);
                        break;
                    case "Truck":
                        result = Caller.CallMethod(info, truck);
                        break;
                }
                Console.WriteLine(result);
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
        }
    }
}
