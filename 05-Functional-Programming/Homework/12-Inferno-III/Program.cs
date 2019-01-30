using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> gems = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToList();

        List<string> excludes = new List<string>();

        string line = Console.ReadLine();

        while (line != "Forge")
        {
            string[] tokens = line.Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (tokens[0] == "Exclude")
            {
                excludes.Add(tokens[1] + " " + tokens[2]);
            }else if (tokens[0] == "Reverse")
            {
                excludes.Remove(tokens[1] + " " + tokens[2]);
            }

            line = Console.ReadLine();
        }

        excludes.Reverse();

        foreach (var exclude in excludes)
        {
            string[] tokens = exclude.Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (tokens[1] == "Left" && tokens[2] == "Right")
            {
                for (int i = 0; i < gems.Count; i++)
                {
                    int sum = GetSum(i,gems,tokens[1] + " " + tokens[2]);

                    if (sum == int.Parse(tokens[3]))
                    {
                        gems.RemoveAt(i);
                        i--;
                    }
                }
            }else if (tokens[1] == "Left")
            {
                for (int i = 0; i < gems.Count; i++)
                {
                    int sum = GetSum(i, gems, tokens[1]);

                    if (sum == int.Parse(tokens[2]))
                    {
                        gems.RemoveAt(i);
                        i--;
                    }
                }
            }
            else if (tokens[1] == "Right")
            {
                for (int i = 0; i < gems.Count; i++)
                {
                    int sum = GetSum(i, gems, tokens[1]);

                    if (sum == int.Parse(tokens[2]))
                    {
                        gems.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        Console.WriteLine(string.Join(" ",gems));
    }

    private static int GetSum(int index, List<int> gems, string sumType)
    {
        if (sumType == "Left Right")
        {
            if (gems.Count == 1)
            {
                return gems[0];
            }

            if (index == 0)
            {
                return gems[index] + gems[index + 1];
            }

            if (index == gems.Count - 1)
            {
                return gems[index] + gems[index - 1];
            }

            return gems[index] + gems[index - 1] + gems[index + 1];
           
        }

        if (sumType == "Left")
        {
            if (index == 0)
            {
                return gems[index];
            }

            return gems[index] + gems[index - 1];
        }

        if (index == gems.Count - 1)
        {
            return gems[index];
        }

        return gems[index] + gems[index + 1];
    }
}

