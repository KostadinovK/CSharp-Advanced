
using System;

public class Person : IComparable<Person>
{
    public string Name { get; set; }

    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public int CompareTo(Person other)
    {
        int compare = this.Name.CompareTo(other.Name);

        if (compare == 0)
        {
            compare = this.Age.CompareTo(other.Age);
        }

        return compare;
    }

    public override string ToString()
    {
        return Name + " " + Age;
    }
}

