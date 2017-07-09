using System;
using System.Text;

namespace Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get => facultyNumber;
            set
            {
                if (value.Length < 5 || value.Length > 10)
                    throw new ArgumentException("Invalid faculty number!");

                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            result.AppendLine()
                  .Append($"Faculty Number: {FacultyNumber}");

            return result.ToString();
        }
    }
}
