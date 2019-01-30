using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

        Action<string> printer = x => Console.WriteLine(x);

        names.ForEach(printer);
    }
}

