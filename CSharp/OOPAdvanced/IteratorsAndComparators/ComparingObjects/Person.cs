using System;

namespace ComparingObjects
{
    public class Person : IComparable
    {
        public Person(string name, int age, string town)
        {
            this.Town = town;
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(object obj)
        {
            Person person = obj as Person;
            if (person.Name != Name)
                return Name.CompareTo(person.Name);

            if (person.Age != Age)
                return Age.CompareTo(person.Age);

            if (person.Town != Town)
                return Town.CompareTo(person.Town);

            return 0;
        }
    }
}
