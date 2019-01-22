using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        HashSet<string> usernames = new HashSet<string>();

        int lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            string username = Console.ReadLine();
            usernames.Add(username);
        }

        Console.WriteLine(string.Join(Environment.NewLine,usernames));
    }
}

