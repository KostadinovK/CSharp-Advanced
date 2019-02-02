using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Dictionary<string, Car> carsByModel = new Dictionary<string, Car>();

        int carsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < carsCount; i++)
        {
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            carsByModel.Add(carInfo[0], new Car(carInfo[0],double.Parse(carInfo[1]), double.Parse(carInfo[2])));
        }

        string line = Console.ReadLine();

        while (line != "End")
        {
            string[] tokens = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (tokens[0] == "Drive")
            {
                if (carsByModel.ContainsKey(tokens[1]))
                {
                    if (!carsByModel[tokens[1]].Travel(int.Parse(tokens[2])))
                    {
                        Console.WriteLine("Insufficient fuel for the drive");
                    }
                }
            }

            line = Console.ReadLine();
        }

        foreach (var kvp in carsByModel)
        {
            Console.WriteLine(kvp.Value);
        }
    }
}

