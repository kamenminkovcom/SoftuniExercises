using System;
using System.Collections.Generic;
using System.Linq;
using MondorPlan.Factory;
using MondorPlan.Foods;
using MondorPlan.Moods;

namespace MondorPlan
{
    class StartUp
    {
        private static List<Food> foods = new List<Food>();

        static void Main()
        {
            FoodFactory foodFactory = new FoodFactory();
            MoodFactory moodFactory = new MoodFactory();
            Console.ReadLine().Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries)
                              .ToList()
                              .ForEach(x => foods.Add(foodFactory.CreateInstace(x.ToLower())));
            int totalPoints = foods.Select(x => x.Points).Sum();
            Mood mood = moodFactory.CreateInstance(totalPoints);
            Console.WriteLine(mood.ToString());
        }
    }
}
