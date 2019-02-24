using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool gameOver = false;
        int player1X = 0;
        int player1Y = 0;
        char player1Trail = 'f';

        int player2X = 0;
        int player2Y = 0;
        char player2Trail = 's';

        char[,] matrix = new char[n,n];

        for (int row = 0; row < n; row++)
        {
            char[] line = Console.ReadLine().ToCharArray();

            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = line[col];

                if (matrix[row,col] == 'f')
                {
                    player1X = row;
                    player1Y = col;
                }else if (matrix[row,col] == 's')
                {
                    player2X = row;
                    player2Y = col;
                }
            }
        }

        Player player1 = new Player(n,player1X, player1Y, player1Trail);
        Player player2 = new Player(n, player2X, player2Y, player2Trail);

        while (!gameOver)
        {
            string[] movement = Console.ReadLine().Split().ToArray();
            string player1Move = movement[0];
            string player2Move = movement[1];

            switch (player1Move)
            {
                case "up":
                    player1.MoveUp();
                    break;
                case "down":
                    player1.MoveDown();
                    break;
                case "left":
                    player1.MoveLeft();
                    break;

                case "right":
                    player1.MoveRight();
                    break;
                    
            }

            if (matrix[player1.Row, player1.Col] == '*')
            {
                matrix[player1.Row, player1.Col] = 'f';
            }
            else if (matrix[player1.Row, player1.Col] == 's')
            {
                matrix[player1.Row, player1.Col] = 'x';
                gameOver = true;
            }

            if (gameOver)
            {
                break;
            }

            switch (player2Move)
            {
                case "up":
                    player2.MoveUp();
                    break;
                case "down":
                    player2.MoveDown();
                    break;
                case "left":
                    player2.MoveLeft();
                    break;
                case "right":
                    player2.MoveRight();
                    break;
            }

            if (matrix[player2.Row, player2.Col] == '*')
            {
                matrix[player2.Row, player2.Col] = 's';
            }
            else if (matrix[player2.Row, player2.Col] == 'f')
            {
                matrix[player2.Row, player2.Col] = 'x';
                gameOver = true;
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(matrix[row,col]);
            }

            Console.WriteLine();
        }

    }
}

public class Player
{
    private int matrixSize;

    public int Row { get; set; }
    public int Col { get; set; }
    public char Trail { get; set; }

    public Player(int matrixSize, int row, int col, char trail)
    {
        this.matrixSize = matrixSize;
        Row = row;
        Col = col;
        Trail = trail;
    }

    public void MoveUp()
    {
        Row--;
        if (Row < 0)
        {
            Row = matrixSize - 1;
        }
    }

    public void MoveDown()
    {
        Row++;
        if (Row >= matrixSize)
        {
            Row = 0;
        }
    }

    public void MoveLeft()
    {
        Col--;
        if (Col < 0)
        {
            Col = matrixSize - 1;
        }
    }

    public void MoveRight()
    {
        Col++;
        if (Col >= matrixSize)
        {
            Col = 0;
        }
    }
}
