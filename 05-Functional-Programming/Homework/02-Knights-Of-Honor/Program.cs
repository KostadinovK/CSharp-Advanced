using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

        Action<List<string>> printer = x => Console.WriteLine(string.Join('\n', x.Select(y => $"Sir {y}")));

        printer(names);
    }
}

