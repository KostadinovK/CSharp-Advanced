using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

public class Person
{
    public string Name { get; set; }

    public Company Company { get; set; }

    public Car Car { get; set; }

    public List<Parent> Parents { get; set; }

    public List<Child> Children { get; set; }

    public List<Pokemon> Pokemon { get; set; }


    public Person(string name)
    {
        Name = name;
        Company = null;
        Car = null;
        Parents = new List<Parent>();
        Children = new List<Child>();
        Pokemon = new List<Pokemon>();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine(Name);
        sb.AppendLine("Company:");

        if (Company != null)
        {
            sb.AppendLine(Company.ToString());
        }

        sb.AppendLine("Car:");
        if (Car != null)
        {
            sb.AppendLine(Car.ToString());
        }

        sb.AppendLine("Pokemon:");

        if (Pokemon != null)
        {
            foreach (var pokemon in Pokemon)
            {
                sb.AppendLine(pokemon.ToString());
            }
        }

        
        sb.AppendLine("Parents:");

        if (Parents != null)
        {
            foreach (var parent in Parents)
            {
                sb.AppendLine(parent.ToString());
            }
        }

        
        sb.AppendLine("Children:");

        if (Children != null)
        {
            foreach (var child in Children)
            {
                sb.AppendLine(child.ToString());
            }
        }

        return sb.ToString();
    }
}

