using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        HashSet<string> table = new HashSet<string>();

        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string line = Console.ReadLine();
            string[] elements = line.Split().ToArray();
            for (int j = 0; j < elements.Length; j++)
            {
                table.Add(elements[j]);
            }
        }

        table = table.OrderBy(x => x).ToHashSet();
        Console.WriteLine(string.Join(" ",table));
    }
}

