using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        int[,] matrix = new int[sizes[0],sizes[1]];

        for (int i = 0; i < sizes[0]; i++)
        {
            int[] rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < rowValues.Length; j++)
            {
                matrix[i, j] = rowValues[j];
            }
        }

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            int colSum = 0;

            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                colSum += matrix[j, i];
            }

            Console.WriteLine(colSum);
        }
    }
}
