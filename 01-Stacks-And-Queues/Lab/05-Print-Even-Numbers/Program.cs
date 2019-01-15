using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Queue<int> evens = new Queue<int>(nums.Where(x => x % 2 == 0));

        Console.WriteLine(string.Join(", ",evens));
    }
}
