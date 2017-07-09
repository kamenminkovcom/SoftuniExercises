using System;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace BookLibrary
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Author
        {
            get => author;
            set
            {
                Regex regex = new Regex("^[A-Za-z].+$");
                string lastName = value.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)[1];
                var propName = MethodBase.GetCurrentMethod().Name.Substring(4);
                if (!regex.IsMatch(lastName))
                    throw new ArgumentException($"{propName} is not valid!");
                author = value;
            }
        }

        public string Title
        {
            get => title;
            set
            {
                var propName = MethodBase.GetCurrentMethod().Name.Substring(4);
                if (value.Length < 3)
                    throw new ArgumentException($"{propName} is not valid!");

                title = value;
            }
        }

        public virtual decimal Price
        {
            get => price;
            set
            {
                var propName = MethodBase.GetCurrentMethod().Name.Substring(4);
                if (value <= 0)
                    throw new ArgumentException($"{propName} is not valid!");

                price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Type: {GetType().Name}")
                .AppendLine($"Title: {Title}")
                .AppendLine($"Author: {Author}")
                .Append($"Price: {Price:f2}");

            return result.ToString();
        }
    }
}
