using System.Drawing;

namespace Tic_Tac_Toe
{
    internal class Game
    {
        char[,] board = new char[3, 3]
            {
                {' ', ' ', ' '},
                {' ', ' ', ' '},
                {' ', ' ', ' '}
            };
        char player1 = 'X';
        char player2 = 'O';
        char currentPlayer;
        int turnCount = 0;
        public Game()
        {
            currentPlayer = player1;
            Play();
        }

        private void Play()
        {
            while (!GameOver())
            {
                int row;
                int col;
                do
                {
                    Draw();
                    row = GetInput("Enter the row");
                    col = GetInput("Enter the column");
                } while (board[row, col] != ' ');
                board[row, col] = currentPlayer;
                if (currentPlayer == player1)
                {
                    currentPlayer = player2;
                }
                else
                {
                    currentPlayer = player1;
                }
                turnCount++;
            }
            Draw();
            Console.WriteLine("Game Over");
            Console.ReadKey();
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
            if (turnCount == 9)
            {
                return true;
            }
            return false;
        }

        public void Draw()
        {
            Console.Clear();
            Console.WriteLine(" |1|2|3|");
            Console.WriteLine("-+-+-+-+");
            for (int row = 0; row < 3; row++)
            {
                Console.Write((row + 1) + "|");
                for (int coloumn = 0; coloumn < 3; coloumn++)
                {
                    Console.Write(board[row, coloumn]);
                    Console.Write("|");
                }
                Console.WriteLine("\n-+-+-+-+");
            }
            Console.WriteLine();
        }

        private int GetInput(string prompt, int upperBound = 3)
        /// <summary>
        /// Takes a prompt and then writes the prompt
        /// out. Then keeps writing over the readline
        /// portion until given input is adequet.
        /// </summary>
        {
            //Define Variables
            string? input;
            int value;
            Point cursorStart;

            //Function Operations
            Console.Write(prompt + ": ");
            cursorStart = new(Console.CursorLeft, Console.CursorTop);
            while (true)
            {
                Console.SetCursorPosition(cursorStart.X, cursorStart.Y);
                input = Console.ReadLine();
                if (input != null)
                {
                    if (int.TryParse(input, out value))
                    {
                        if (value >= 1 && value <= upperBound)
                        {
                            return value - 1;
                        }
                    }
                    Console.SetCursorPosition(cursorStart.X, cursorStart.Y);
                    for (int i = 0; i < input.Length; i++)
                    {
                        Console.Write(' ');
                    }
                }
            }
        }
    }
}
