using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string line = Console.ReadLine();

        string[] tokens = line.Split().ToArray();

        CustomTuple<string, string, string> tuple1 = new CustomTuple<string, string, string>(tokens[0] + " " + tokens[1], tokens[2], tokens[3]);

        line = Console.ReadLine();
        tokens = line.Split().ToArray();

        bool isDrunk = tokens[2] == "drunk";

        CustomTuple<string, int, bool> tuple2 = new CustomTuple<string, int, bool>(tokens[0], int.Parse(tokens[1]), isDrunk);

        line = Console.ReadLine();
        tokens = line.Split().ToArray();

        CustomTuple<string, double, string> tuple3 = new CustomTuple<string, double, string>(tokens[0], double.Parse(tokens[1]), tokens[2]);

        Console.WriteLine(tuple1);
        Console.WriteLine(tuple2);
        Console.WriteLine(tuple3);
    }
}
