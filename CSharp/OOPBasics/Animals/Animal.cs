using System;
using System.Text;

namespace Animals
{
    abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Inavlid input.");
                name = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Invalid input.");
                age = value;
            }
        }

        public string Gender
        {
            get => gender;
            set
            {
                string help = value.ToLower();

                if (help != "male" && help != "female")
                    throw new ArgumentException("Inavlid input.");

                gender = value;
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{GetType().Name}")
                .AppendLine($"{Name} {Age} {Gender}")
                .Append($"{ProduceSound()}");
            return result.ToString();
        }
    }
}
