using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();

        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

        for (int i = 0; i < int.Parse(input[0]); i++)
        {
            string[] rectInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

            rectangles.Add(rectInfo[0], new Rectangle(rectInfo[0],double.Parse(rectInfo[1]), double.Parse(rectInfo[2])
                ,double.Parse(rectInfo[3]), double.Parse(rectInfo[4])));


        }

        for (int i = 0; i < int.Parse(input[1]); i++)
        {
            string[] pair = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Console.WriteLine(rectangles[pair[0]].Intersects(rectangles[pair[1]]));
            
        }
    }
}

