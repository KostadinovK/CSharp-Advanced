using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

        int rackCapacity = int.Parse(Console.ReadLine());

        int racks = 1;
        int remainingCapacity = rackCapacity;
        while (clothes.Count > 0)
        {
            int cloth = clothes.Pop();
            if (remainingCapacity - cloth > 0)
            {
                remainingCapacity -= cloth;
            }else if (remainingCapacity - cloth == 0)
            {
                if (clothes.Count > 0)
                {
                    racks++;
                    remainingCapacity = rackCapacity;
                }
            }else if (remainingCapacity - cloth < 0)
            {
                racks++;
                remainingCapacity = rackCapacity;
                remainingCapacity -= cloth;
            }
        }

        Console.WriteLine(racks);
    }
}
