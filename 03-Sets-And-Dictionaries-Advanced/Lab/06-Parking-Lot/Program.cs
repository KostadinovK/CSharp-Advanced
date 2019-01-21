using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        HashSet<string> parking = new HashSet<string>();

        string line = Console.ReadLine();

        while (line != "END")
        {
            string[] tokens = line.Split(", ",StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (tokens[0] == "IN")
            {
                parking.Add(tokens[1]);
            }else if (tokens[0] == "OUT")
            {
                if (parking.Contains(tokens[1]))
                {
                    parking.Remove(tokens[1]);
                }
            }

            line = Console.ReadLine();
        }

        if (parking.Any())
        {
            Console.WriteLine(string.Join('\n',parking));
        }
        else
        {
            Console.WriteLine("Parking Lot is Empty");
        }
    }
}

