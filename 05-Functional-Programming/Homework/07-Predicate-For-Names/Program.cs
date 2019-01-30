using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int maxNameLenght = int.Parse(Console.ReadLine());
        string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

        Func<string, bool> filter = CreateFilter(maxNameLenght);

        Console.WriteLine(string.Join('\n',names.Where(filter)));
    }

    private static Func<string, bool> CreateFilter(int maxNameLenght)
    {
        return x => x.Length <= maxNameLenght;
    }
}
