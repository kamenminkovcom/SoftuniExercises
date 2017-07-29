using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class StartUp
    {
        static void Main()
        {
            SortedSet<Person> nameStartegy = new SortedSet<Person>(new NameLengthStrategy());
            SortedSet<Person> ageStartegy = new SortedSet<Person>(new AgeStrategy());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(personInfo[0], int.Parse(personInfo[1]));
                nameStartegy.Add(person);
                ageStartegy.Add(person);
            }

            foreach (var person in nameStartegy)
            {
                Console.WriteLine(person.ToString());
            }

            foreach (var person in ageStartegy)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
