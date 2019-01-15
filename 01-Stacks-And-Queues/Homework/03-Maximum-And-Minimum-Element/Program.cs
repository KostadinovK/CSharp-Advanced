using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Stack<int> stack = new Stack<int>();

        int queries = int.Parse(Console.ReadLine());

        for (int i = 0; i < queries; i++)
        {
            string query = Console.ReadLine();
            if (query.Contains("1"))
            {
                int[] nums = query.Split().Select(int.Parse).ToArray();
                stack.Push(nums[1]);
            }else if (query == "2")
            {
                if (stack.Count != 0)
                {
                    stack.Pop();
                }
            }else if (query == "3")
            {
                if (stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                
            }else if (query == "4")
            {
                if (stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }

        Console.WriteLine(string.Join(", ",stack));
    }
}
