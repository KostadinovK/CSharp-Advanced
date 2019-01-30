using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> nums = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        string line = Console.ReadLine();

        
        while (line != "end")
        {
            Func<int, int> applyOperation = CreateOperation(line);
            if (line != "print")
            {
                
                nums = nums.Select(applyOperation).ToList();
            }
            else
            {
                Console.WriteLine(string.Join(" ", nums));
            }

            
            line = Console.ReadLine();
        }
    }

    private static Func<int, int> CreateOperation(string line)
    {
        if (line == "add")
        {
            return x => x + 1;
        }

        if (line == "subtract")
        {
            return x => x - 1;
        }

        return x => x * 2;
    }
}
