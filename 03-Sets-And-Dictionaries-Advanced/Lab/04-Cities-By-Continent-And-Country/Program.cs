using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var continents = new Dictionary<string,Dictionary<string,List<string>>>();

        int lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            string[] tokens = Console.ReadLine().Split().ToArray();
            string continent = tokens[0];
            string country = tokens[1];
            string city = tokens[2];

            if (!continents.ContainsKey(continent))
            {
                continents[continent] = new Dictionary<string, List<string>>();
            }

            if (!continents[continent].ContainsKey(country))
            {
                continents[continent][country] = new List<string>();
            }

            continents[continent][country].Add(city);
        }

        foreach (var continent in continents)
        {
            Console.WriteLine($"{continent.Key}:");
            foreach (var country in continent.Value)
            {
                Console.WriteLine($"  {country.Key} -> {string.Join(", ",country.Value)}");
            }
        }
    }
}

