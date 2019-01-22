using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var vlogger = new Dictionary<string, KeyValuePair<HashSet<string>,HashSet<string>>>();

        string line = Console.ReadLine();

        while (line != "Statistics")
        {
            string[] tokens = line.Split().ToArray();
            string vloger = tokens[0];
            string command = tokens[1];

            if (command == "joined")
            {
                if (!vlogger.ContainsKey(vloger))
                {
                    vlogger[vloger] = new KeyValuePair<HashSet<string>, HashSet<string>>(new HashSet<string>(), new HashSet<string>());
                    
                }
            }else if (command == "followed")
            {
                string otherVloger = tokens[2];

                if (vlogger.ContainsKey(vloger) && vlogger.ContainsKey(otherVloger) && vloger != otherVloger)
                {
                    vlogger[vloger].Key.Add(otherVloger);
                    vlogger[otherVloger].Value.Add(vloger);
                }
            }

            line = Console.ReadLine();
        }

        Console.WriteLine($"The V-Logger has a total of {vlogger.Count} vloggers in its logs.");
        int place = 1;
        foreach (var kvp in vlogger.OrderByDescending(x => x.Value.Value.Count).ThenBy(x => x.Value.Key.Count))
        {

            Console.WriteLine($"{place}. {kvp.Key} : {kvp.Value.Value.Count} followers, {kvp.Value.Key.Count} following");
            if (place == 1)
            {
                foreach (var follower in kvp.Value.Value.OrderBy(x => x))
                {
                    Console.WriteLine("*  " + follower);
                }
            }

            place++;
        }
    }
}
