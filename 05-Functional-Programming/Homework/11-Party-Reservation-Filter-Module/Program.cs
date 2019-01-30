using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public class Program
{
    public static void Main()
    {
        List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

        List<string> filters = new List<string>();

        string line = Console.ReadLine();

        while (line != "Print")
        {
            string[] tokens = line.Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (tokens[0] == "Add filter")
            {
                filters.Add(tokens[1] + " " + tokens[2]);
            }else if (tokens[0] == "Remove filter")
            {
                filters.Remove(tokens[1] + " " + tokens[2]);
            }


            line = Console.ReadLine();
        }

        foreach (var filter in filters)
        {
            string[] tokens = filter.Split().ToArray();

            if (tokens[0] == "Starts")
            {
                names = names.Where(x => !x.StartsWith(tokens[2])).ToList();
            }else if (tokens[0] == "Ends")
            {
                names = names.Where(x => !x.EndsWith(tokens[2])).ToList();
            }else if (tokens[0] == "Contains")
            {
                names = names.Where(x => !x.Contains(tokens[1])).ToList();
            }else if (tokens[0] == "Length")
            {
                names = names.Where(x => x.Length != int.Parse(tokens[1])).ToList();
            }
        }

        Console.WriteLine(string.Join(" ",names));
    }
    
}
