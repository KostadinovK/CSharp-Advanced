using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] line1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int numbersToPush = line1[0];
        int numbersToPop = line1[1];
        int searchFor = line1[2];

        int[] line2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Queue<int> nums = new Queue<int>(line2);

        numbersToPop = Math.Min(numbersToPop, nums.Count);
        for (int i = 0; i < numbersToPop; i++)
        {
            nums.Dequeue();
        }

        if (nums.Count == 0)
        {
            Console.WriteLine(0);
        }
        else if (nums.Contains(searchFor))
        {
            Console.WriteLine("true");
        }
        else if (!nums.Contains(searchFor))
        {
            Console.WriteLine(nums.Min());
        }
    }
}
