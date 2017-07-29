using System;

namespace EqualityLogic
{
    public class Person : IComparable
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            
            Person person = obj as Person;

            if (person == null)
                return false;

            return Name == person.Name && Age == person.Age;
        }

        public override int GetHashCode()
        {
            int hash = 997;
            unchecked
            {
                hash = hash * 17 ^ Name.GetHashCode();
                hash = hash * 17 ^ Age.GetHashCode();
                return hash;
            }
        }

        public int CompareTo(object obj)
        {
            Person person = obj as Person;

            if (person.Age != Age)
                return Age.CompareTo(person.Age);
            return Name.CompareTo(person.Name);
        }
    }
}
