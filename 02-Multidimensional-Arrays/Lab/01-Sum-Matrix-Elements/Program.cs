using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        int sum = 0;
        for (int i = 0; i < sizes[0]; i++)
        {
            int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (int j = 0; j < nums.Length; j++)
            {
               sum += nums[j];
            }
        }

        Console.WriteLine(sizes[0]);
        Console.WriteLine(sizes[1]);
        Console.WriteLine(sum);
    }
}
