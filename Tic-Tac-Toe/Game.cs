using System.Drawing;

namespace Tic_Tac_Toe
{
    internal class Game
    {
        private char[,] board;
        readonly char player1 = 'X';
        readonly char player2 = 'O';
        char currentPlayer;
        int turnCount = 0;
        CancellationTokenSource cancellationTokenSource;
        Thread escapeCheck;

        public Game()
        {
            board = new char[3, 3]
            {
                {' ', ' ', ' '},
                {' ', ' ', ' '},
                {' ', ' ', ' '}
            };
            currentPlayer = player1;
            cancellationTokenSource = new();
            escapeCheck  = new Thread(() => EscapeGameCheck(cancellationTokenSource.Token));
            //escapeCheck.Start();
            Play();
        }

        private void Play()
        {
            InitialDraw();
            Point inputCursorPositionInit = new(Console.CursorLeft, Console.CursorTop);
            while (!GameOver())
            {
                int row;
                int col;
                do{
                    row = GetInput("Enter the row", inputCursorPositionInit);
                    col = GetInput("Enter the column", inputCursorPositionInit);
                } while (board[row, col] != ' ');
                board[row, col] = currentPlayer;
                UpdateDraw();
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
            UpdateDraw();
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
                    cancellationTokenSource.Cancel();
                    return true;
                }
            }
            //Checks for column win conditions
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == board[1, col] && board[1, col] == board[2, col] && board[0, col] != ' ')
                {
                    cancellationTokenSource.Cancel();
                    return true;
                }
            }
            //Checks for diagonal win conditions
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[1, 1] != ' ')
            {
                cancellationTokenSource.Cancel();
                return true;
            }
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[1, 1] != ' ')
            {
                cancellationTokenSource.Cancel();
                return true;
            }
            //Checks for draw condition
            if (turnCount == 9)
            {
                cancellationTokenSource.Cancel();
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
                    Console.SetCursorPosition((col*2)+colOffset, (row*2)+rowOffset);
                    Console.Write(board[row, col]);
                }
            }
            /*
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
            */
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

        private static int GetInput(string prompt, Point init, int upperBound = 3)
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
            Console.SetCursorPosition((int)init.X, (int)init.Y);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition((int)init.X, (int)init.Y);
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

        private static void EscapeGameCheck(CancellationToken token)
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();
            } while (keyInfo.Key != ConsoleKey.Escape && !token.IsCancellationRequested);
            Menu.Menus.MainMenu();
        }
    }
}
