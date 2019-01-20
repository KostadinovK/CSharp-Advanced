using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] sizes = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        string[,] matrix = new string[sizes[0],sizes[1]];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string[] values = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = values[col];
            }
        }

        string command = Console.ReadLine();
        while (command != "END")
        {
            string[] args = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (args[0] == "swap" && args.Length == 5)
            {
                int row1 = int.Parse(args[1]);
                int col1 = int.Parse(args[2]);
                int row2 = int.Parse(args[3]);
                int col2 = int.Parse(args[4]);

                if (IsValidPos(row1,col1,matrix) && IsValidPos(row2,col2,matrix))
                {
                    string temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;

                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            command = Console.ReadLine();
        }
    }

    private static void PrintMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row,col] + " ");
            }

            Console.WriteLine();
        }
    }

    private static bool IsValidPos(int row, int col, string[,] matrix)
    {
        if ((row >= 0 && row < matrix.GetLength(0)) && (col >= 0 && col < matrix.GetLength(1)))
        {
            return true;
        }

        return false;
    }
}
