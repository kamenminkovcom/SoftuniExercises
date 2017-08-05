namespace _01HarestingFields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    class HarvestingFieldsTest
    {
        static void Main()
        {
            Type harvestType = typeof(HarvestingFields);
            var fileds = harvestType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "HARVEST")
                {
                    return;
                }

                switch (input)
                {
                    case "protected":
                        GetFields(fileds.Where(x => x.IsFamily));
                        break;
                    case "public":
                        GetFields(fileds.Where(x => x.IsPublic));
                        break;
                    case "private":
                        GetFields(fileds.Where(x => x.IsPrivate));
                        break;
                    case "all":
                        GetFields(fileds);
                        break;
                }
            }
        }

        public static void GetFields(IEnumerable<FieldInfo> fields)
        {
            foreach (var field in fields)
            {
                Console.WriteLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}".Replace("family", "protected"));
            }
        }
    }
}
