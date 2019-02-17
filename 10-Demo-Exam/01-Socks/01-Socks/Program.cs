using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> pairs = new List<int>();

        int[] leftSocksValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] rightSocksValues = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Stack<int> leftSocks = new Stack<int>(leftSocksValues);
        Queue<int> rightSocks = new Queue<int>(rightSocksValues);

        while (leftSocks.Any() && rightSocks.Any())
        {
            int currentLeftSock = leftSocks.Peek();
            int currentRightSock = rightSocks.Peek();

            if (currentLeftSock > currentRightSock)
            {
                pairs.Add(currentRightSock + currentLeftSock);
                leftSocks.Pop();
                rightSocks.Dequeue();
            }else if (currentLeftSock == currentRightSock)
            {
                rightSocks.Dequeue();
                leftSocks.Pop();
                leftSocks.Push(currentLeftSock + 1);
            }
            else
            {
                leftSocks.Pop();
            }
        }

        Console.WriteLine(pairs.Max());
        Console.WriteLine(string.Join(" ", pairs));
    }
}
