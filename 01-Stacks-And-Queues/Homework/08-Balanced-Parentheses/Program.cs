using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{

    public static void Main(string[] args)
    {
        string line = Console.ReadLine();

        Stack<char> brackets = new Stack<char>();

        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] == '{')
            {
                brackets.Push(line[i]);
            }

            if (line[i] == '[')
            {
                brackets.Push(line[i]);
            }

            if (line[i] == '(')
            {
                brackets.Push(line[i]);
            }

            if (line[i] == '}')
            {
                if (brackets.Any() && brackets.Peek() == '{')
                {
                    brackets.Pop();
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            if (line[i] == ']')
            {
                if (brackets.Any() && brackets.Peek() == '[')
                {
                    brackets.Pop();
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            if (line[i] == ')')
            {
                if (brackets.Any() && brackets.Peek() == '(')
                {
                    brackets.Pop();
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }


        }

        if (brackets.Any())
        {
            Console.WriteLine("NO");
        }
        else
        {
            Console.WriteLine("YES");
        }
    }
}
