using System;
using WildFarm.AnimalClasses;
using WildFarm.Factories;
using WildFarm.FoodClasses;

namespace WildFarm
{
    class StartUp
    {
        static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] animalInfo = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string[] foodInfo = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                Animal animal = AnimalFactory.CreateInstance(animalInfo) as Animal;
                Food food = FoodFactory.CreateInstance(foodInfo) as Food;
                animal.MakeSound();
                try
                {
                    animal.Eat(food);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
