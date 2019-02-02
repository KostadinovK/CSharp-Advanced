public class Employee
{
    public string Name { get; private set; }

    public double Salary { get; private set; }

    public string Position { get; private set; }

    public string Department { get; private set; }

    public string Email { get; private set; }

    public int Age { get; private set; }

    public Employee()
    {
    }

    public Employee(string name, double salary, string position, string department, string email = "n/a", int age = -1)
    {
        Name = name;
        Salary = salary;
        Position = position;
        Department = department;
        Email = email;
        Age = age;
    }

    public override string ToString()
    {
        return Name + " " + $"{Salary:f2}" + " " + Email + " " + Age;
    }
}

