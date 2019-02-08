using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
       
        string line = Console.ReadLine();

        string[] tokens = line.Split().ToArray();

        CustomTuple<string, string> tuple1 = new CustomTuple<string, string>(tokens[0] + " " + tokens[1], tokens[2]);

        line = Console.ReadLine();
        tokens = line.Split().ToArray();

        CustomTuple<string, int> tuple2 = new CustomTuple<string, int>(tokens[0], int.Parse(tokens[1]));

        line = Console.ReadLine();
        tokens = line.Split().ToArray();

        CustomTuple<int,double> tuple3 = new CustomTuple<int, double>(int.Parse(tokens[0]), double.Parse(tokens[1]));

        Console.WriteLine(tuple1);
        Console.WriteLine(tuple2);
        Console.WriteLine(tuple3);
    }
}
