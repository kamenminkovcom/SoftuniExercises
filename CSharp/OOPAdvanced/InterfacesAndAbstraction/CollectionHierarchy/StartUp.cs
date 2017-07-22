using System;
using System.Collections.Generic;

class StartUp
{
    public static AddCollection<string> addCollection = new AddCollection<string>();
    public static AddRemoveCollection<string> addRemoveCollection = new AddRemoveCollection<string>();
    public static MyList<string> myList = new MyList<string>();

    static void Main()
    {
        string[] inputOpeartions = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
        int removeOperations = int.Parse(Console.ReadLine());

        foreach (var element in inputOpeartions)
        {
            addCollection.Add(element);
            addRemoveCollection.Add(element);
            myList.Add(element);
        }

        for (int i = 0; i < removeOperations; i++)
        {
            addRemoveCollection.Remove();
            myList.Remove();
        }

        Console.WriteLine(string.Join(" ", addCollection.Adds));
        Console.WriteLine(string.Join(" ", addRemoveCollection.Adds));
        Console.WriteLine(string.Join(" ", myList.Adds));
        Console.WriteLine(string.Join(" ", addRemoveCollection.Removes));
        Console.WriteLine(string.Join(" ", myList.Removes));
    }
}

