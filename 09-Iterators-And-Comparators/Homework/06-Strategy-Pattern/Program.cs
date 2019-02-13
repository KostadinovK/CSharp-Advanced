using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        SortedSet<Person> byName = new SortedSet<Person>(new PersonNameComparer());
        SortedSet<Person> byAge = new SortedSet<Person>(new PersonAgeComparer());

        int peoples = int.Parse(Console.ReadLine());

        for (int i = 0; i < peoples; i++)
        {
            string[] personInfo = Console.ReadLine().Split().ToArray();

            byName.Add(new Person(personInfo[0], int.Parse(personInfo[1])));
            byAge.Add(new Person(personInfo[0], int.Parse(personInfo[1])));
        }

        foreach (var person in byName)
        {
            Console.WriteLine(person);
        }

        foreach (var person in byAge)
        {
            Console.WriteLine(person);
        }
    }
}
