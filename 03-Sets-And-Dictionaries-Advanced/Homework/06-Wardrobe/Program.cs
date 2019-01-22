using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Dictionary<string,Dictionary<string,int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

        int lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string[] tokens = Console.ReadLine()
                .Split(new string[] {",", " -> "}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string color = tokens[0];
            if (!wardrobe.ContainsKey(color))
            {
                wardrobe[color] = new Dictionary<string, int>();
            }

            for (int j = 1; j < tokens.Length; j++)
            {
                if (!wardrobe[color].ContainsKey(tokens[j]))
                {
                    wardrobe[color][tokens[j]] = 0;
                }

                wardrobe[color][tokens[j]]++;
            }
        }

        string[] searchFor = Console.ReadLine().Split().ToArray();

        foreach (var kvp in wardrobe)
        {
            Console.WriteLine($"{kvp.Key} clothes: ");
            foreach (var cloth in kvp.Value)
            {
                if (kvp.Key == searchFor[0] && cloth.Key == searchFor[1])
                {
                    Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                }
                else
                {
                    Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                }
            }
        }
    }
}

