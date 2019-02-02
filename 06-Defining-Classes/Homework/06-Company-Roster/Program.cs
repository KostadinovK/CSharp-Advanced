using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Dictionary<string, List<Employee>> employees = new Dictionary<string, List<Employee>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string name = tokens[0];
            double salary = double.Parse(tokens[1]);
            string position = tokens[2];
            string department = tokens[3];
            string email = "n/a";
            int age = -1;

            if (tokens.Length > 4)
            {
                if (tokens[4].Contains("@"))
                {
                    email = tokens[4];
                }
                else
                {
                    age = int.Parse(tokens[4]);
                }
            }

            if (tokens.Length == 6)
            {
                if (tokens[5].Contains("@"))
                {
                    email = tokens[5];
                }
                else
                {
                    age = int.Parse(tokens[5]);
                }
            }

            if (!employees.ContainsKey(department))
            {
                employees[department] = new List<Employee>();
            }

            employees[department].Add(new Employee(name,salary,position,department,email,age));
        }

        double maxAverageSalary = 0;
        string maxDepartment = "";
        foreach (var kvp in employees)
        {
            if (kvp.Value.Average(x => x.Salary) > maxAverageSalary)
            {
                maxAverageSalary = kvp.Value.Average(x => x.Salary);
                maxDepartment = kvp.Key;
            }
        }

        Console.WriteLine("Highest Average Salary: " + maxDepartment);

        foreach (var employee in employees[maxDepartment].OrderByDescending(x => x.Salary))
        {
            Console.WriteLine(employee);
        }
    }
}

