using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();

        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);

        list.ForEach(Console.WriteLine);

        int[] arr = list.ToArray();

        Console.WriteLine(string.Join(" ", arr));
    }
}
