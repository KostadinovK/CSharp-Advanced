using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] sizes = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int[,] matrix = new int[sizes[0],sizes[1]];

        for (int row = 0; row < sizes[0]; row++)
        {
            int[] nums = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int col = 0; col < sizes[1]; col++)
            {
                matrix[row, col] = nums[col];
            }
        }

        int maxSum = int.MinValue;
        int[,] matrixWithMaxSum = new int[3,3];

        for (int row = 0; row < sizes[0] - 2; row++)
        {
            for (int col = 0; col < sizes[1] - 2; col++)
            {
                int sum = GetSum(row, col, matrix);

                if (sum > maxSum)
                {
                    maxSum = sum;
                    matrixWithMaxSum = Get3x3MatrixFromStartPoint(row,col,matrix);
                }
            }
        }

        Console.WriteLine("Sum = " + maxSum);

        for (int row = 0; row < matrixWithMaxSum.GetLength(0); row++)
        {
            for (int col = 0; col < matrixWithMaxSum.GetLength(1); col++)
            {
                if (col == 2)
                {
                    Console.Write(matrixWithMaxSum[row, col]);
                }
                else
                {
                    Console.Write(matrixWithMaxSum[row, col] + " ");
                }
                
            }

            Console.WriteLine();
        }
    }

    private static int[,] Get3x3MatrixFromStartPoint(int row, int col, int[,] matrix)
    {
        int[,] res = new int[3,3];

        res[0, 0] = matrix[row, col];
        res[0, 1] = matrix[row, col + 1];
        res[0, 2] = matrix[row, col + 2];
        res[1, 0] = matrix[row + 1, col];
        res[1, 1] = matrix[row + 1, col + 1];
        res[1, 2] = matrix[row + 1, col + 2];
        res[2, 0] = matrix[row + 2, col];
        res[2, 1] = matrix[row + 2, col + 1];
        res[2, 2] = matrix[row + 2, col + 2];

        return res;
    }

    private static int GetSum(int row, int col, int[,] matrix)
    {
        int sum = 0;
        sum += matrix[row, col];
        sum += matrix[row + 1, col];
        sum += matrix[row, col + 1];
        sum += matrix[row + 1, col + 1];
        sum += matrix[row + 2, col];
        sum += matrix[row + 2, col + 1];
        sum += matrix[row, col + 2];
        sum += matrix[row + 1, col + 2];
        sum += matrix[row + 2, col + 2];

        return sum;
    }
}
