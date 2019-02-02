using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Dictionary<string, Person> persons = new Dictionary<string, Person>();

        string line = Console.ReadLine();

        while (line != "End")
        {
            string[] tokens = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string name = tokens[0];

            if (!persons.ContainsKey(name))
            {
                persons[name] = new Person(name);
            }

            if (tokens[1] == "company")
            {
                string companyName = tokens[2];
                string department = tokens[3];
                double salary = double.Parse(tokens[4]);
                Company company = new Company(companyName, department, salary);

                persons[name].Company = company;
            }
            else if (tokens[1] == "pokemon")
            {
                string pokemonName = tokens[2];
                string pokemonType = tokens[3];

                Pokemon pokemon = new Pokemon(pokemonName, pokemonType);

                persons[name].Pokemon.Add(pokemon);
            }
            else if (tokens[1] == "parents")
            {
                string parentName = tokens[2];
                string parentBirthday = tokens[3];

                persons[name].Parents.Add(new Parent(parentName, parentBirthday));
            }
            else if (tokens[1] == "children")
            {
                string childName = tokens[2];
                string childBirthday = tokens[3];

                persons[name].Children.Add(new Child(childName, childBirthday));
            }
            else if (tokens[1] == "car")
            {
                string carModel = tokens[2];
                int carSpeed = int.Parse(tokens[3]);

                persons[name].Car = new Car(carModel, carSpeed);
            }

            line = Console.ReadLine();
        }


        line = Console.ReadLine();

        Console.WriteLine(persons[line]);
    }
}
