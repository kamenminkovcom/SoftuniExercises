using System;
using System.Collections.Generic;
using ComparingObjects;

namespace ComparingObjects
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString() => $"{Name} {Age}";
    }

    public class NameLengthStrategy : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Name.Length != y.Name.Length)
                return x.Name.Length.CompareTo(y.Name.Length);
            return x.Name.ToLower()[0].CompareTo(y.Name.ToLower()[0]);
        }
    }

    public class AgeStrategy : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
