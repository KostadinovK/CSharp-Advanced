using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        HashSet<Person> hashSet = new HashSet<Person>(new EqualityComparer());
        SortedSet<Person> sortedSet = new SortedSet<Person>();

        int peoples = int.Parse(Console.ReadLine());

        for (int i = 0; i < peoples; i++)
        {
            string[] personInfo = Console.ReadLine().Split().ToArray();

            hashSet.Add(new Person(personInfo[0], int.Parse(personInfo[1])));
            sortedSet.Add(new Person(personInfo[0], int.Parse(personInfo[1])));
        }

        Console.WriteLine(hashSet.Count);
        Console.WriteLine(sortedSet.Count);
    }
}

