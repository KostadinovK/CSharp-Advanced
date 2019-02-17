using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[][] matrix = new string[n][];
        int rowDataLength = 0;

        for (int row = 0; row < n; row++)
        {
            string[] rowData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            rowDataLength = rowData.Length;
            matrix[row] = new string[rowDataLength];
            for (int col = 0; col < rowDataLength; col++)
            {
                matrix[row][col] = rowData[col];
            }
        }

        string[] commandArgs = Console.ReadLine().Split().ToArray();

        if (commandArgs[0] == "hide")
        {
            int hideIndex = 0;

            for (int i = 0; i < rowDataLength; i++)
            {
                if (matrix[0][i] == commandArgs[1])
                {
                    hideIndex = i;
                    break;
                }
            }

            matrix = matrix.Select(x => x.Where((item, i) => i != hideIndex).ToArray()).ToArray();

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < rowDataLength - 1; col++)
                {
                    if (col == rowDataLength - 2)
                    {
                        Console.Write(matrix[row][col]);
                    }
                    else
                    {
                        Console.Write(matrix[row][col] + " | ");
                    }

                }

                Console.WriteLine();
            }
        }
        else if (commandArgs[0] == "sort")
        {
            
            int sortIndex = 0;

            for (int i = 0; i < rowDataLength; i++)
            {
                if (matrix[0][i] == commandArgs[1])
                {
                    sortIndex = i;
                    break;
                }
            }

            for (int i = 0; i < rowDataLength; i++)
            {
                if (i == rowDataLength - 1)
                {
                    Console.Write(matrix[0][i]);
                }
                else
                {
                    Console.Write(matrix[0][i] + " | ");
                }

               
            }

            Console.WriteLine();
            matrix = matrix.Skip(1).OrderBy(x => x[sortIndex]).ToArray();

            for (int row = 0; row < n-1; row++)
            {
                for (int col = 0; col < rowDataLength; col++)
                {
                    if (col == rowDataLength - 1)
                    {
                        Console.Write(matrix[row][col]);
                    }
                    else
                    {
                        Console.Write(matrix[row][col] + " | ");
                    }

                }

                Console.WriteLine();
            }
        }
        else if (commandArgs[0] == "filter")
        {
            int filterIndex = 0;

            for (int i = 0; i < rowDataLength; i++)
            {
                if (matrix[0][i] == commandArgs[1])
                {
                    filterIndex = i;
                    break;
                }
            }

            for (int row = 0; row < n; row++)
            {
                if (matrix[row][filterIndex] == commandArgs[2] || row == 0)
                {
                    for (int col = 0; col < rowDataLength; col++)
                    {
                        if (col == rowDataLength - 1)
                        {
                            Console.Write(matrix[row][col]);
                        }
                        else
                        {
                            Console.Write(matrix[row][col] + " | ");
                        }

                    }

                    Console.WriteLine();
                }

            }
        }




    }
}
