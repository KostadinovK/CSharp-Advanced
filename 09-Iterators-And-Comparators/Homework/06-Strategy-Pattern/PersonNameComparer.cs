
using System.Collections.Generic;

public class PersonNameComparer : IComparer<Person>
{
    public int Compare(Person a, Person b)
    {
        int compare = a.Name.Length.CompareTo(b.Name.Length);

        if (compare == 0)
        {
            compare = a.Name.ToLower().CompareTo(b.Name.ToLower());
        }

        return compare;
    }
}

