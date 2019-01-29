using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        Func<double, double> Adder = x => x * 1.2;
        

        List<double> prices = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .Select(Adder)
            .ToList();

        Action<double> PrintFormated = x => Console.WriteLine($"{x:f2}");

        prices.ForEach(PrintFormated);
    }
}
