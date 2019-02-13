
using System.Collections;
using System.Collections.Generic;

class EqualityComparer : IEqualityComparer<Person>
{
    public bool Equals(Person a, Person b)
    {
        return a.Name == b.Name && a.Age == b.Age;
    }

    public int GetHashCode(Person obj)
    {
        return obj.Name.Length * obj.Age - obj.Name[0];
    }
}
