using System;
using System.Linq;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int[,] matrix = new int[size,size];

        for (int row = 0; row < size; row++)
        {
            int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = rowValues[col];
            }
        }

        int diagonalSum = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (row == col)
                {
                    diagonalSum += matrix[row, col];
                }
            }
        }

        Console.WriteLine(diagonalSum);
    }
}
