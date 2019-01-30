using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] bounds = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        string condition = Console.ReadLine();

        Func<int,bool> filter = CreateEvenOrOddFilter(condition);

        for (int i = bounds[0]; i <= bounds[1]; i++)
        {
            if (filter(i))
            {
                Console.Write(i + " ");
            }
        }
    }

    private static Func<int, bool> CreateEvenOrOddFilter(string condition)
    {
        if (condition == "even")
        {
            return x => x % 2 == 0;
        }

        return x => x % 2 != 0;
    }
}
