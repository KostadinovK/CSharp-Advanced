using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int bulletPrice = int.Parse(Console.ReadLine());
        int barrelSize = int.Parse(Console.ReadLine());
        int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int money = int.Parse(Console.ReadLine());


        Stack<int> bulletsValue = new Stack<int>(bullets);
        Queue<int> locksValue = new Queue<int>(locks);

        int startingBullets = bulletsValue.Count;
        int count = 0;
        while (bulletsValue.Any() && locksValue.Any())
        {
            int bullet = bulletsValue.Pop();
            int lok = locksValue.Peek();
            if (bullet <= lok)
            {
                Console.WriteLine("Bang!");
                locksValue.Dequeue();
            }
            else
            {
                Console.WriteLine("Ping!");
            }

            count++;
            if (count == barrelSize && bulletsValue.Any())
            {
                Console.WriteLine("Reloading!");
                count = 0;
            }
        }

        if (!bulletsValue.Any() && locksValue.Any())
        {
            Console.WriteLine($"Couldn't get through. Locks left: {locksValue.Count}");
        }else if (bulletsValue.Any())
        {
            Console.WriteLine($"{bulletsValue.Count} bullets left. Earned ${money - ((startingBullets - bulletsValue.Count) * bulletPrice)}");
        }else if (!bulletsValue.Any() && !locksValue.Any())
        {
            Console.WriteLine($"{bulletsValue.Count} bullets left. Earned ${money - (startingBullets * bulletPrice)}");
        }
    }
}
