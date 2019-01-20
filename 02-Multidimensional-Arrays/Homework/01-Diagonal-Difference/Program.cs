using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int[,] matrix = new int[size,size];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = nums[col];
            }
        }

        int firstDiagonalSum = 0;
        int secondDiagonalSum = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (row == col)
                {
                    firstDiagonalSum += matrix[row, col];
                }

                if (col == matrix.GetLength(1) - row - 1)
                {
                    secondDiagonalSum += matrix[row, col];
                }
            }
        }

        Console.WriteLine(Math.Abs(firstDiagonalSum - secondDiagonalSum));

    }
}
