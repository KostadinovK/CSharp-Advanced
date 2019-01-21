using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int lines = int.Parse(Console.ReadLine());

        Dictionary<string,List<double>> grades = new Dictionary<string, List<double>>();

        for (int i = 0; i < lines; i++)
        {
            string[] line = Console.ReadLine().Split().ToArray();
            string name = line[0];
            double grade = double.Parse(line[1]);

            if (!grades.ContainsKey(name))
            {
                grades[name] = new List<double>();
            }

            grades[name].Add(grade);
        }

        foreach (var kvp in grades)
        {
            Console.Write($"{kvp.Key} -> ");
            foreach (var grade in kvp.Value)
            {
                Console.Write($"{grade:f2} ");
            }

            Console.WriteLine($"(avg: {kvp.Value.Average():f2})");
        }
    }
}

