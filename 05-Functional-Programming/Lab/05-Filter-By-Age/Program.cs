using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Dictionary<string,int> yearsByNames = new Dictionary<string, int>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            yearsByNames[line[0]] = int.Parse(line[1]);
        }

        string filterString = Console.ReadLine();
        int filterAge = int.Parse(Console.ReadLine());

        string[] printFormat = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

        Func<int, bool> filter = CreateFilter(filterString, filterAge);
        Action<KeyValuePair<string, int>> printer = CreatePrinter(printFormat);

        ForEach(yearsByNames,filter,printer);

    }

    private static Func<int, bool> CreateFilter(string filterString, int filterAge)
    {
        if (filterString == "older")
        {
            return x => x >= filterAge;
        }

        return x => x < filterAge;
    }

    private static Action<KeyValuePair<string, int>> CreatePrinter(string[] printFormat)
    {
        if (printFormat.Length == 2)
        {
            return kvp => Console.WriteLine($"{kvp.Key} - {kvp.Value}");
        }

        if (printFormat[0] == "name")
        {
            return kvp => Console.WriteLine($"{kvp.Key}");
        }

        return kvp => Console.WriteLine($"{kvp.Value}");
    }

    private static void ForEach(Dictionary<string, int> names, Func<int,bool> filter, Action<KeyValuePair<string,int>> printer)
    {
        foreach (var kvp in names)
        {
            if (filter(kvp.Value))
            {
                printer(kvp);
            }
        }
    }
}

