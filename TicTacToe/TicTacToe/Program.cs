using System;

namespace TicTacToe
{
    class Program
    {
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static char currentPlayer = 'X';

        static void Main(string[] args)
        {
            int move;
            bool gameWon = false;

            do
            {
                Console.Clear();
                DisplayBoard();
                Console.WriteLine($"Player {currentPlayer}, choose your move (1-9): ");
                move = int.Parse(Console.ReadLine());

                if (board[move - 1] != 'X' && board[move - 1] != 'O')
                {
                    board[move - 1] = currentPlayer;
                    gameWon = CheckWin();

                    if (!gameWon)
                    {
                        currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
                    }
                }

            } while (!gameWon && !CheckDraw());

            Console.Clear();
            DisplayBoard();

            if (gameWon)
                Console.WriteLine($"Player {currentPlayer} wins!");
            else
                Console.WriteLine("It's a draw!");
        }

        static void DisplayBoard()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {board[0]}  |  {board[1]}  |  {board[2]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {board[3]}  |  {board[4]}  |  {board[5]}");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine($"  {board[6]}  |  {board[7]}  |  {board[8]}");
            Console.WriteLine("     |     |      ");
        }

        static bool CheckWin()
        {
            // Define win conditions and check them
            // (Implement checking logic for rows, columns, and diagonals)
            return false; // Placeholder
        }

        static bool CheckDraw()
        {
            // Check if all cells are filled
            foreach (var cell in board)
            {
                if (cell != 'X' && cell != 'O')
                    return false;
            }
            return true;
        }
    }
}
