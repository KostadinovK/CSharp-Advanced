using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

        Func<string, int, bool> filter = (string s, int x) =>
        {
            int sum = 0;
            foreach (var c in s)
            {
                sum += (int) c;
            }

            return sum >= x;
        };

        foreach (var name in names)
        {
            if (filter(name,n))
            {
                Console.WriteLine(name);
                break;
            }
        }
    }
}
