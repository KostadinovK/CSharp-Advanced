using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Queue<string> kids = new Queue<string>(Console.ReadLine().Split());
        int turns = int.Parse(Console.ReadLine());
        int turn = 0;
        while (kids.Count > 1)
        {
            turn++;
            string kid = kids.Dequeue();
            if (turn != turns)
            {
                kids.Enqueue(kid);
            }
            else
            {
                turn = 0;
                Console.WriteLine($"Removed {kid}");
            }
        }

        string lastKid = kids.Dequeue();
        Console.WriteLine($"Last is {lastKid}");
    }
}
