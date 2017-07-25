using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        //it is easy to change the type of a comparison
        //just change the type of the input you would like to receive
        //e.g.: here you can change double with string or decimal
        int n = int.Parse(Console.ReadLine());
        List<Box<double>> list = new List<Box<double>>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            list.Add(new Box<double>(double.Parse(input)));
        }
        double comparison = double.Parse(Console.ReadLine());
        Console.WriteLine(GreatererCount(list, comparison));   
    }

    public static void Swap<T>(List<T> list, int index1, int index2)
    {
        var help = list[index1];
        list[index1] = list[index2];
        list[index2] = help;
    }
            
    public static int GreatererCount<T, M>(List<T> list, M element)
        where T : IComparable
    {
       return list.Count(x => x.CompareTo(element) > 0);
    }
}

