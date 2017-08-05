using System.Reflection;

namespace _02BlackBoxInteger
{
    using System;

    class BlackBoxIntegerTests
    {
        static void Main()
        {
            Type[] types = new Type[] { typeof(int) };
            object[] prameteres = new object[] { 0 };

            var blackBox = CreateInstance<BlackBoxInt>(types, prameteres);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    return;
                }

                string[] commands = input.Split(new[] { "_" }, StringSplitOptions.RemoveEmptyEntries);

                Call(blackBox, commands[0], new object[] { int.Parse(commands[1]) });

                Console.WriteLine(GetResult("innerValue", blackBox));
            }
        }

        public static T CreateInstance<T>(Type[] paramTypes, object[] parameters)
        {
            Type type = typeof(T);

            ConstructorInfo constructor =
                type.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, paramTypes, null);

            return (T)constructor.Invoke(parameters);
        }

        public static void Call<T>(T instance, string methodName, object[] parameters)
        {
            MethodInfo method = typeof(T).GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);
            method.Invoke(instance, parameters);
        }

        public static int GetResult<T>(string fieldName, T instance)
        {
            return (int)typeof(T).GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance)
                .GetValue(instance);
        }
    }
}
