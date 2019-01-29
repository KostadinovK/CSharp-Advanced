using System;
using System.Globalization;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

        Func<string, bool> filter = x => char.IsUpper(x[0]);

        Console.WriteLine(string.Join('\n', text.Where(filter)));
    }
}

