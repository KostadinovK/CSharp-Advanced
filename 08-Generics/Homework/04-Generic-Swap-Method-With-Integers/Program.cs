using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<Box<int>> list = new List<Box<int>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Box<int> box = new Box<int>();
            int number = int.Parse(Console.ReadLine());
            box.Add(number);
            list.Add(box);
        }

        int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Swap(list, indexes[0], indexes[1]);

        foreach (var box in list)
        {
            Console.WriteLine(box.ToString());
        }
    }

    private static void Swap<T>(List<T> list, int index1, int index2)
    {
        T temp = list[index1];
        list[index1] = list[index2];
        list[index2] = temp;
    }
}
