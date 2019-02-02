using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Dictionary<string, Car> carsByModel = new Dictionary<string, Car>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            string model = carInfo[0];
            double speed = double.Parse(carInfo[1]);
            double power = double.Parse(carInfo[2]);
            double weight = double.Parse(carInfo[3]);
            string type = carInfo[4];

            double tire1Pressure = double.Parse(carInfo[5]);
            int tire1Age = int.Parse(carInfo[6]);

            double tire2Pressure = double.Parse(carInfo[7]);
            int tire2Age = int.Parse(carInfo[8]);

            double tire3Pressure = double.Parse(carInfo[9]);
            int tire3Age = int.Parse(carInfo[10]);

            double tire4Pressure = double.Parse(carInfo[11]);
            int tire4Age = int.Parse(carInfo[12]);

            if (!carsByModel.ContainsKey(model))
            {
                carsByModel.Add(model, new Car(model, speed, power, weight, type,tire1Pressure, tire1Age
                    ,tire2Pressure, tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age));
            }

        }

        string line = Console.ReadLine();

        Func<Car, bool> filter = CreateFilter(line);

        Console.WriteLine(string.Join("\n",carsByModel.Values.Where(filter).ToList()));
    }

    private static Func<Car, bool> CreateFilter(string type)
    {
        if (type == "fragile")
        {
            return x => x.Cargo.Type == type && x.Tires.Where(y => y.Pressure < 1).ToArray().Length != 0;
        }

        return x => x.Cargo.Type == type && x.Engine.Power > 250;
    }
}

