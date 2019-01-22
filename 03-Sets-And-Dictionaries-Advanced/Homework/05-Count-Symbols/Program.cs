using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Dictionary<char, int> occurrences = new Dictionary<char, int>();

        string line = Console.ReadLine();
        for (int i = 0; i < line.Length; i++)
        {
            if (!occurrences.ContainsKey(line[i]))
            {
                occurrences[line[i]] = 0;
            }

            occurrences[line[i]]++;
        }

        foreach (var kvp in occurrences.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
        }
    }
}

