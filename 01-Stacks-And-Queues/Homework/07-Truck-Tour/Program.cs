using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var pumps = int.Parse(Console.ReadLine());
        var startIndex = 0;
        var fuel = 0;

        for (int i = 0; i < pumps; i++)
        {
            int[] props = Console.ReadLine().Split().Select(int.Parse).ToArray();

            fuel += props[0] - props[1];

            if (fuel < 0)
            {
                fuel = 0;
                startIndex = i + 1;
            }
        }

        Console.WriteLine(startIndex);

    }
}
