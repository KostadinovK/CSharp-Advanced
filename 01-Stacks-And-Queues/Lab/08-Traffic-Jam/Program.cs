using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int passingCarsCount = int.Parse(Console.ReadLine());

        Queue<string> cars = new Queue<string>();
        int passed = 0;

        string line = Console.ReadLine();

        while (line != "end")
        {
            if (line == "green")
            {
                int passedCars = Math.Min(cars.Count, passingCarsCount);
                for (int i = 0; i < passedCars; i++)
                {
                    passed++;
                    Console.WriteLine($"{cars.Dequeue()} passed!");
                }
            }
            else
            {
                cars.Enqueue(line);
            }

            line = Console.ReadLine();
        }

        Console.WriteLine($"{passed} cars passed the crossroads.");
    }
}
