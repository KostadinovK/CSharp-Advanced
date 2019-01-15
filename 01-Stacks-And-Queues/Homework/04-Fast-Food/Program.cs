﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int foodQuantity = int.Parse(Console.ReadLine());

        Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

        Console.WriteLine(orders.Max());

        while (orders.Count > 0)
        {
            int order = orders.Peek();
            if (foodQuantity >= order)
            {
                foodQuantity -= order;
                orders.Dequeue();
            }
            else
            {
                break;
            }
        }

        if (orders.Count == 0)
        {
            Console.WriteLine("Orders complete");
        }
        else
        {
            Console.WriteLine("Orders left: " + string.Join(" ",orders));
        }
    }
}
