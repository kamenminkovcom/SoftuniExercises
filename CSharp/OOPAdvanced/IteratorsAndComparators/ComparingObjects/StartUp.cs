using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    class StartUp
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                    break;

                string[] info = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                people.Add(new Person(info[0], int.Parse(info[1]), info[2]));
            }

            int index = int.Parse(Console.ReadLine());

            int equal = NumberOfEqual(people, people[index - 1]);

            if (equal == 1)
            {
                Console.WriteLine("No matches");
                return;
            }
            Console.WriteLine($"{equal} {people.Count - equal} {people.Count}");
        }

        public static int NumberOfEqual(List<Person> people, Person person)
        {
            return people.Count(x => x.CompareTo(person) == 0);
        }
    }
}
