using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Family family = new Family();
        int members = int.Parse(Console.ReadLine());

        for (int i = 0; i < members; i++)
        {
            string[] tokens = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            Person p = new Person(tokens[0], int.Parse(tokens[1]));
            family.AddMember(p);
        }

        Console.WriteLine(family.GetOldestMember().ToString());
    }
}

