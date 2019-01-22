using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] lengths = Console.ReadLine().Split().Select(int.Parse).ToArray();

        HashSet<int> firstSet = new HashSet<int>(lengths[0]);
        HashSet<int> secondSet = new HashSet<int>(lengths[1]);

        for (int i = 0; i < lengths[0] + lengths[1]; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (i < lengths[0])
            {
                firstSet.Add(num);
            }
            else
            {
                secondSet.Add(num);
            }

        }

        firstSet.IntersectWith(secondSet);
        Console.WriteLine(string.Join(" ",firstSet));
    }
}

