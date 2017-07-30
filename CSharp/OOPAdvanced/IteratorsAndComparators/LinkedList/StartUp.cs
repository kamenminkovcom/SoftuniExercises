using System;
using System.Reflection;
using System.Security;

namespace LinkedList
{
    class StartUp
    {
        static void Main()
        {
            int operationsNumber = int.Parse(Console.ReadLine());
            LinkedList<int> linkedList = new LinkedList<int>();
            for (int i = 0; i < operationsNumber; i++)
            {
                string[] operation = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                Call(linkedList, operation[0], int.Parse(operation[1]));
            }

            Console.WriteLine(linkedList.Count);
            Console.WriteLine(linkedList.ToString());
        }

        private static void Call<T>(LinkedList<T> list, string method, int param)
            where T : IComparable<T>
        {
            Type type = typeof(LinkedList<T>);
            MethodInfo methodInfo = type.GetMethod(method);
            methodInfo.Invoke(list, new object[] {param});
        }
    }
}
