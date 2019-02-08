using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Box<string>> list = new List<Box<string>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            Box<string> box = new Box<string>();
            box.Add(line);
            list.Add(box);
        }

        string toCompareWith = Console.ReadLine();
        Box<string> toCompare = new Box<string>();
        toCompare.Add(toCompareWith);

        Console.WriteLine(GetBiggerElementsCount(list, toCompare));
    }

    private static int GetBiggerElementsCount<T>(List<T> list, T toCompareWith) where T : IComparable<T>
    {
        int count = 0;
        foreach (var boxes in list)
        {
            if (boxes.CompareTo(toCompareWith) == 1)
            {
                count++;
            }
        }

        return count;
    }
}
