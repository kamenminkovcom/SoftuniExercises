using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Stack
{
    class StartUp
    {
        public static Stack<int> stack = new Stack<int>();

        static void Main()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                    break;

                List<string> elements = input.Split(new[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (elements[0] == "Push")
                {
                    Push(elements);
                    continue;
                }
                try
                {
                    stack.Pop();
                }
                catch
                {
                    Console.WriteLine("No elements");
                }
            }

            for (int i = 0; i <= 1; i++)
            {
                foreach (var element in stack)
                {
                    Console.WriteLine(element);
                }
            }
        }

        public static void Push(List<string> input)
        {
            input
                .RemoveAt(0);
            input
                .Select(int.Parse)
                .ToList()
                .ForEach(x => stack.Push(x));
        }
    }
}
