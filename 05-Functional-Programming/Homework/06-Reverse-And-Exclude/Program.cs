using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int num = int.Parse(Console.ReadLine());

        nums = nums.Reverse().ToArray();

        Func<int, bool> filter = CreateFilter(num);

        Console.WriteLine(string.Join(" ", nums.Where(filter).ToList()));
        
    }

    private static Func<int, bool> CreateFilter(int num)
    {
        return x => x % num != 0;
    }
}

