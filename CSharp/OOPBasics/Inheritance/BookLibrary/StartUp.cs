using System;

namespace BookLibrary
{
    class StartUp
    {
        static void Main()
        {
            var goldEdition = new GoldenEditionBook("Ruska ruletka", "Kamen Minkov", 9);
            Console.WriteLine(goldEdition.ToString());
        }
    }
}
