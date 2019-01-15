using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Stack<char> chars = new Stack<char>(input);

        Console.WriteLine(chars.ToArray());
    }
}
