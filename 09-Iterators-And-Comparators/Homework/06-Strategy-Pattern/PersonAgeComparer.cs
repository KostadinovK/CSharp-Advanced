
using System.Collections.Generic;

public class PersonAgeComparer : IComparer<Person>
{
    public int Compare(Person a, Person b)
    {
        return a.Age.CompareTo(b.Age);
    }
}
