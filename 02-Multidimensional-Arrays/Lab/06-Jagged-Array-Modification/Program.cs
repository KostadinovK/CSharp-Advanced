using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
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

        string command = Console.ReadLine();
        while (command != "END")
        {
            string[] commandArgs = command.Split();

            string commandName = commandArgs[0];
            int rowTo = int.Parse(commandArgs[1]);
            int colTo = int.Parse(commandArgs[2]);
            int to = int.Parse(commandArgs[3]);

            if (rowTo < 0 || rowTo >= matrix.GetLength(0))
            {
                Console.WriteLine("Invalid coordinates");
                command = Console.ReadLine();
                continue;
            }

            if (colTo < 0 || colTo >= matrix.GetLength(1))
            {
                Console.WriteLine("Invalid coordinates");
                command = Console.ReadLine();
                continue;
            }

            if (commandName == "Add")
            {
                matrix[rowTo, colTo] += to;


            }else if (commandName == "Subtract")
            {
                matrix[rowTo, colTo] -= to;
            }

            command = Console.ReadLine();
        }

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write(matrix[row,col] + " ");
            }

            Console.WriteLine();
        }
    }
}
