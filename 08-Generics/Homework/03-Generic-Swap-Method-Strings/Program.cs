using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        List<Box<string>> list = new List<Box<string>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Box<string> box = new Box<string>();
            string line = Console.ReadLine();
            box.Add(line);
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

