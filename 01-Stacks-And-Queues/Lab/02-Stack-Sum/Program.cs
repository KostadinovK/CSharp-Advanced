using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Stack<int> nums = new Stack<int>(input);

        string command = Console.ReadLine().ToLower();
        while (command != "end")
        {
            string[] tokkens = command.Split();
            if (tokkens[0] == "add")
            {
                int num1 = int.Parse(tokkens[1]);
                int num2 = int.Parse(tokkens[2]);
                nums.Push(num1);
                nums.Push(num2);

            }else if (tokkens[0] == "remove")
            {
                int numsToRemove = int.Parse(tokkens[1]);
                if (numsToRemove <= nums.Count)
                {
                    for (int i = 0; i < numsToRemove; i++)
                    {
                        nums.Pop();
                    }
                }
            }

            command = Console.ReadLine().ToLower();
        }

        Console.WriteLine($"Sum: {nums.Sum()}");
    }
}
