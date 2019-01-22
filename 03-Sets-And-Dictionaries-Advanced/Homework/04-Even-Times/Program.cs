using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Dictionary<int,int> occurrences = new Dictionary<int, int>();

        int nums = int.Parse(Console.ReadLine());
        for (int i = 0; i < nums; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (!occurrences.ContainsKey(num))
            {
                occurrences[num] = 0;
            }

            occurrences[num]++;
        }

        foreach (var kvp in occurrences)
        {
            if (kvp.Value % 2 == 0)
            {
                Console.WriteLine(kvp.Key);
                break;
            }
        }
    }
}

