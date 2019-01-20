﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

public class Program
{
    private class Bomb
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Bomb()
        {
        }

        public Bomb(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        int[,] matrix = new int[size,size];

        for (int row = 0; row < size; row++)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = nums[col];
            }
        }

        string[] bombsValue = Console.ReadLine().Split().ToArray();
        Queue<Bomb> bombs = new Queue<Bomb>();

        for (int i = 0; i < bombsValue.Length; i++)
        {
            int bombX = bombsValue[i].Split(",").Select(int.Parse).ToArray()[0];
            int bombY = bombsValue[i].Split(",").Select(int.Parse).ToArray()[1];

            Bomb b = new Bomb(bombX,bombY);
            bombs.Enqueue(b);
        }

        while (bombs.Count > 0)
        {
            Bomb bomb = bombs.Dequeue();
            if (matrix[bomb.X,bomb.Y] > 0)
            {
                DamageCells(bomb,ref matrix);
                matrix[bomb.X, bomb.Y] = 0;
            }
        }

        int aliveCells = 0;
        int aliveCellsSum = 0;

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (matrix[row,col] > 0)
                {
                    aliveCells++;
                    aliveCellsSum += matrix[row, col];
                }
            }
        }

        Console.WriteLine("Alive cells: " + aliveCells);
        Console.WriteLine("Sum: " + aliveCellsSum);

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write(matrix[row,col] + " ");
            }

            Console.WriteLine();
        }
    }

    private static void DamageCells(Bomb bomb, ref int[,] matrix)
    {
        if (IsValidPos(bomb.X + 1, bomb.Y + 1,matrix) && matrix[bomb.X + 1, bomb.Y + 1] > 0)
        {
            matrix[bomb.X + 1, bomb.Y + 1] -= matrix[bomb.X,bomb.Y];
        }

        if (IsValidPos(bomb.X - 1, bomb.Y - 1, matrix) && matrix[bomb.X - 1, bomb.Y - 1] > 0)
        {
            matrix[bomb.X - 1, bomb.Y - 1] -= matrix[bomb.X, bomb.Y];
        }

        if (IsValidPos(bomb.X + 1, bomb.Y - 1, matrix) && matrix[bomb.X + 1, bomb.Y - 1] > 0)
        {
            matrix[bomb.X + 1, bomb.Y - 1] -= matrix[bomb.X, bomb.Y];
        }

        if (IsValidPos(bomb.X - 1, bomb.Y + 1, matrix) && matrix[bomb.X - 1, bomb.Y + 1] > 0)
        {
            matrix[bomb.X - 1, bomb.Y + 1] -= matrix[bomb.X, bomb.Y];
        }

        if (IsValidPos(bomb.X + 1, bomb.Y, matrix) && matrix[bomb.X + 1, bomb.Y] > 0)
        {
            matrix[bomb.X + 1, bomb.Y] -= matrix[bomb.X, bomb.Y];
        }
        if (IsValidPos(bomb.X - 1, bomb.Y, matrix) && matrix[bomb.X - 1, bomb.Y] > 0)
        {
            matrix[bomb.X - 1, bomb.Y] -= matrix[bomb.X, bomb.Y];
        }

        if (IsValidPos(bomb.X, bomb.Y + 1, matrix) && matrix[bomb.X, bomb.Y + 1] > 0)
        {
            matrix[bomb.X, bomb.Y + 1] -= matrix[bomb.X, bomb.Y];
        }

        if (IsValidPos(bomb.X, bomb.Y - 1, matrix) && matrix[bomb.X, bomb.Y - 1] > 0)
        {
            matrix[bomb.X, bomb.Y - 1] -= matrix[bomb.X, bomb.Y];
        }
    }

    private static bool IsValidPos(int row, int col, int[,] matrix)
    {
        if ((row >= 0 && row < matrix.GetLength(0))&&(col >= 0 && col < matrix.GetLength(1)))
        {
            return true;
        }

        return false;
    }
}
