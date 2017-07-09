using System;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        private decimal salary;
        private int workingHours;

        public Worker(string firstName, string lastName, decimal salary, int workingHours) : base(firstName, lastName)
        {
            this.Salary = salary;
            this.WorkingHours = workingHours;
        }

        public decimal Salary
        {
            get => salary;
            set
            {
                if (value <= 10)
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");

                salary = value;
            }
        }

        public int WorkingHours
        {
            get => workingHours;
            set
            {
                if (value<1 || value > 12)
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                workingHours = value;
            }
        }

        public decimal SalaryPerHour => Salary / (WorkingHours * 5);    

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            result.AppendLine()
                .AppendLine($"Week Salary: {Salary}")
                .AppendLine($"Hour per day: {WorkingHours}")
                .Append($"Salary per hour: {SalaryPerHour:f2}");

            return result.ToString();
        }
    }
}
