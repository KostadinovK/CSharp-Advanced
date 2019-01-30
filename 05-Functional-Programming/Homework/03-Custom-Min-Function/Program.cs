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

        Func<int[], int[]> printMinElement = arr =>
        {
            int min = Int32.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine(min);
            return arr;
        };

        printMinElement(nums);
    }
}

