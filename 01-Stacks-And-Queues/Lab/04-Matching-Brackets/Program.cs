using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string line = Console.ReadLine();
        Stack<int> bracketsIndex = new Stack<int>();

        for (int i = 0; i < line.Length;i++)
        {
            if (line[i] == '(')
            {
                bracketsIndex.Push(i);
            }

            if (line[i] == ')')
            {
                int endIndex = i;
                int startIndex = bracketsIndex.Pop();

                Console.WriteLine(line.Substring(startIndex,endIndex - startIndex + 1));
            }
        }

    }
}
