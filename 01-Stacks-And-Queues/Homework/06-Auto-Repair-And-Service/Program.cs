using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Queue<string> carsForService = new Queue<string>(Console.ReadLine().Split());
        Stack<string> servicedCars = new Stack<string>();

        string command = Console.ReadLine();

        while (command != "End")
        {
            if (command == "Service")
            {
                if (carsForService.Count > 0)
                {
                    string car = carsForService.Dequeue();
                    servicedCars.Push(car);
                    Console.WriteLine($"Vehicle {car} got served.");
                }
            }else if (command == "History")
            {
                Console.WriteLine(string.Join(", ",servicedCars));
            }
            else if(command.Contains("CarInfo-"))
            {
                string car = command.Split('-').ToArray()[1];
                if (carsForService.Contains(car))
                {
                    Console.WriteLine("Still waiting for service.");
                }else if (servicedCars.Contains(car))
                {
                    Console.WriteLine("Served.");
                }
            }

            command = Console.ReadLine();
        }

        if (carsForService.Count > 0)
        {
            Console.WriteLine("Vehicles for service: " + string.Join(", ",carsForService));
        }

        if (servicedCars.Count > 0)
        {
            Console.WriteLine("Served vehicles: " + string.Join(", ",servicedCars));
        }
    }
}
