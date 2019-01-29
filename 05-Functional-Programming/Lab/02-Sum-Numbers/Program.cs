using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Action<int[]> action = x => Console.WriteLine(x.Length);
        action += x => Console.WriteLine(x.Sum());

        action(nums);
    }
}

