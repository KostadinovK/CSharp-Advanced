﻿using System;

public class Program
{
    public static void Main()
    {
        CustomList<int> list = new CustomList<int>();

        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Insert(3,22);

        Console.WriteLine(list.Contains(22));
    }
}
