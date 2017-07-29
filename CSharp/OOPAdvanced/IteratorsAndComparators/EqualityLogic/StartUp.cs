using System;
using System.Collections.Generic;
using System.Security;

namespace EqualityLogic
{
    class StartUp
    {
        static void Main()
        {
            SortedSet<Person> sortedSet = new SortedSet<Person>();
            HashSet<Person> hashSet = new HashSet<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(personInfo[0], int.Parse(personInfo[1]));
                sortedSet.Add(person);
                hashSet.Add(person);
            }
            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}
