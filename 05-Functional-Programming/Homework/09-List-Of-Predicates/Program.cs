using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            return;
        }

        int[] dividers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Distinct()
            .ToArray();

        List<int> nums = new List<int>(Enumerable.Range(1, n));

        foreach (var divider in dividers)
        {
            if (divider != 0)
            {
                Func<int, bool> filter = CreateFilter(divider);
                nums = nums.Where(filter).ToList();
            }
        }

        Console.WriteLine(string.Join(" ", nums));
    }

    private static Func<int, bool> CreateFilter(int num)
    {
        return x => x % num == 0;
    }
}

