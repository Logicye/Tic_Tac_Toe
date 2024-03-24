using System.Drawing;
using Tic_Tac_Toe.Handlers;

namespace Tic_Tac_Toe.Game
{
    internal class Game
    {
        private char[,] board;
        readonly char player1 = 'X';
        readonly char player2 = 'O';
        char currentPlayer;
        int turnCount = 0;

        public Game()
        {
            board = new char[3, 3]
            {
                {' ', ' ', ' '},
                {' ', ' ', ' '},
                {' ', ' ', ' '}
            };
            currentPlayer = player1;
            Play();
            Menu.Menus.MainMenu();
        }

        private void Play()
        {
            InitialDraw();
            Point inputCursorPositionInit = new(Console.CursorLeft, Console.CursorTop);
            while (!GameOver())
            {
                int row;
                int col;
                do
                {
                    row = ConsoleHandler.GetInput("Enter the row", inputCursorPositionInit);
                    col = ConsoleHandler.GetInput("Enter the column", inputCursorPositionInit);
                } while (MoveValid(row, col));
                MakeValidMove(row, col);
                UpdateDraw();
            }
            UpdateDraw();
            ConsoleHandler.WriteOverLine("Game Over", inputCursorPositionInit);
        }

        private bool GameOver()
        {
            //Checks for row win conditions
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2] && board[row, 0] != ' ')
                {
                    return true;
                }
            }
            //Checks for column win conditions
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == board[1, col] && board[1, col] == board[2, col] && board[0, col] != ' ')
                {
                    return true;
                }
            }
            //Checks for diagonal win conditions
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[1, 1] != ' ')
            {
                return true;
            }
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[1, 1] != ' ')
            {
                return true;
            }
            //Checks for draw condition
            if (board.Cast<char>().All(x => x != ' '))
            {
                return true;
            }
            return false;
        }

        public void UpdateDraw()
        {
            const int rowOffset = 3;
            const int colOffset = 3;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.SetCursorPosition(col * 2 + colOffset, row * 2 + rowOffset);
                    Console.Write(board[row, col]);
                }
            }
        }

        private static void InitialDraw()
        {
            Console.Clear();
            Console.WriteLine("+++-+-+-+");
            Console.WriteLine("++|1|2|3|");
            Console.WriteLine("|-+-+-+-+");
            Console.WriteLine("|1| | | |");
            Console.WriteLine("|-+-+-+-+");
            Console.WriteLine("|2| | | |");
            Console.WriteLine("|-+-+-+-+");
            Console.WriteLine("|3| | | |");
            Console.WriteLine("+-+-+-+-+");
        }

        private bool MoveValid(int row, int col)
        {
            if (board[row,col] != ' ') return true;
            else return false;
        }
        
        private void MakeValidMove(int row, int col)
        {
            board[row, col] = currentPlayer;
            SwitchCurrentPlayer();
            turnCount++;
        }

        private void SwitchCurrentPlayer()
        {
            if (currentPlayer == player1)
            {
                currentPlayer = player2;
            }
            else
            {
                currentPlayer = player1;
            }
        }
    }
}
