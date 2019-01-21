using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Dictionary<double,int> occurrences = new Dictionary<double, int>();

        double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

        foreach (var num in nums)
        {
            if (!occurrences.ContainsKey(num))
            {
                occurrences[num] = 0;
            }

            occurrences[num]++;
        }

        foreach (var occurrence in occurrences)
        {
            Console.WriteLine($"{occurrence.Key} - {occurrence.Value} times");
        }
    }
}
