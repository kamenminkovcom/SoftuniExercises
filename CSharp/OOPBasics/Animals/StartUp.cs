using System;

namespace Animals
{
    class StartUp
    {
        static void Main()
        {
            AnimalFactory factory = new AnimalFactory();
            Animal animal;
            while (true)
            {
                string type = Console.ReadLine();

                if (type == "Beast!")
                    break;

                string[] animalInfo = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    animal = factory.GetInstance(type, animalInfo);
                }
                catch
                {
                    Console.WriteLine("Inavlid input!");
                    continue;
                }
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
