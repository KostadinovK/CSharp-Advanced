using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine().Split().ToList();
        input.Reverse();
        Stack<string> calc = new Stack<string>(input);
        int res = int.Parse(calc.Pop());

        while (calc.Count > 0)
        {
            string pop = calc.Pop();
            if (pop == "+")
            {
                res += int.Parse(calc.Pop());
            }else if (pop == "-")
            {
                res -= int.Parse(calc.Pop());
            }
        }

        Console.WriteLine(res);
    }
}
