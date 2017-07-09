using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Mankind
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                ValidateNames(value, nameof(firstName));
                firstName = value;
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                ValidateNames(value, nameof(lastName));
                lastName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"First Name: {FirstName}")
                .Append($"Last Name: {LastName}");

            return result.ToString();
        }

        private void ValidateNames(string value, string type)
        {
            Regex regex = new Regex("^[A-Z].+$");

            if (!regex.IsMatch(value))
                throw new ArgumentException($"Expected upper case letter! Argument: {type}");
            if (value.Length < 3)
                throw new ArgumentException($"Expected length at least 4 symbols! Argument: {type}");
        }
    }
}
