using System;
public class Program
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        char[,] matrix = new char[size,size];

        for (int row = 0; row < size; row++)
        {
            char[] rowValues = Console.ReadLine().ToCharArray();
            for (int col = 0; col < rowValues.Length; col++)
            {
                matrix[row, col] = rowValues[col];
            }
        }

        char searchFor = char.Parse(Console.ReadLine());

        int charRow = -1;
        int charCol = -1;

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (matrix[row,col] == searchFor)
                {
                    charRow = row;
                    charCol = col;
                    break;
                }
            }

            if (charRow != -1)
            {
                break;
            }
        }

        if (charRow != -1 && charCol != -1)
        {
            Console.WriteLine($"({charRow}, {charCol})");
        }
        else
        {
            Console.WriteLine($"{searchFor} does not occur in the matrix");
        }


    }
}
