using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Dictionary<string, List<int>> hallsWithPeoples = new Dictionary<string, List<int>>();
        Queue<string> halls = new Queue<string>();

        int maxCapacity = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split().ToArray();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (Char.IsLetter(input[i].ToCharArray()[0]))
            {
                halls.Enqueue(input[i]);
                hallsWithPeoples[input[i]] = new List<int>();
            }
            else if(halls.Count > 0)
            {
                int peoples = int.Parse(input[i]);
                string currentHall = halls.Peek();

                if (hallsWithPeoples[currentHall].Sum() + peoples <= maxCapacity)
                {
                    hallsWithPeoples[currentHall].Add(peoples);
                }
                else
                {
                    Console.WriteLine($"{currentHall} -> {string.Join(", ", hallsWithPeoples[currentHall])}");
                    halls.Dequeue();
                    if (halls.Count > 0)
                    {
                        string nextHall = halls.Peek();
                        if (hallsWithPeoples[nextHall].Sum() + peoples <= maxCapacity)
                        {
                            hallsWithPeoples[nextHall].Add(peoples);
                        }
                    }
                }
            }
        }
    }
}

