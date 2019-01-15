using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        Queue<string> customers = new Queue<string>();

        string line = Console.ReadLine();

        while (line != "End")
        {
            if (line == "Paid")
            {
                Console.WriteLine(string.Join('\n',customers));
                customers.Clear();
            }
            else
            {
                customers.Enqueue(line);
            }

            line = Console.ReadLine();
        }

        Console.WriteLine($"{customers.Count} people remaining.");
    }
}
