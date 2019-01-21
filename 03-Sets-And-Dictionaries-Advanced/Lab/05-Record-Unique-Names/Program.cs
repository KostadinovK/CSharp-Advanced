using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        HashSet<string> names = new HashSet<string>();

        int namesCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < namesCount; i++)
        {
            string name = Console.ReadLine();
            names.Add(name);
        }

        Console.WriteLine(string.Join('\n',names));
    }
}

