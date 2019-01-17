using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        int[,] matrix = new int[sizes[0],sizes[1]];

        int maxSum = int.MinValue;
        int maxRow = -1;
        int maxCol = -1;

        for (int row = 0; row < sizes[0]; row++)
        {
            int[] rowValues = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (int col = 0; col < sizes[1]; col++)
            {
                matrix[row, col] = rowValues[col];
            }
        }

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = row;
                    maxCol = col;
                }
            }
        }

        Console.WriteLine(matrix[maxRow,maxCol] + " " + matrix[maxRow, maxCol + 1]);
        Console.WriteLine(matrix[maxRow + 1,maxCol] + " " + matrix[maxRow + 1, maxCol + 1]);
        Console.WriteLine(maxSum);
    }
}
