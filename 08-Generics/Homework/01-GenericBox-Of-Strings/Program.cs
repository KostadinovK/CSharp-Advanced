using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Box<string> box = new Box<string>();
            string line = Console.ReadLine();
            box.Add(line);
            Console.WriteLine(box.ToString());
        }
    }
}
