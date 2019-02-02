using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    public static void Main()
    {
        Dictionary<string, Person> persons = new Dictionary<string, Person>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            persons.Add(tokens[0], new Person(tokens[0],int.Parse(tokens[1])));
        }

        foreach (var person in persons.Where(x => x.Value.Age > 30).OrderBy(x => x.Key))
        {
            Console.WriteLine(person.Value.ToString());
        }
    }
}

