using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Box<double>> list = new List<Box<double>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            double num = double.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            box.Add(num);
            list.Add(box);
        }

        double toCompareWith = double.Parse(Console.ReadLine());
        Box<double> toCompare = new Box<double>();
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
