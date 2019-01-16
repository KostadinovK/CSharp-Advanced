using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main()
    {
        int operations = int.Parse(Console.ReadLine());
        string text = string.Empty;
        Stack<string> history = new Stack<string>();
        for (int i = 0; i < operations; i++)
        {
            string[] command = Console.ReadLine().Split().ToArray();

            switch (command[0])
            {
                case "1":
                    history.Push(text);
                    StringBuilder sb = new StringBuilder(text);
                    sb.Append(command[1]);
                    text = sb.ToString();
                    break;
                case "2":
                    history.Push(text);
                    int toRemove = int.Parse(command[1]);
                    text = text.Remove(text.Length - toRemove);
                    break;
                case "3":
                    int index = int.Parse(command[1]);
                    Console.WriteLine(text[index - 1]);
                    break;
                case "4":
                    text = history.Pop();
                    break;
            }
        }
    }
}
