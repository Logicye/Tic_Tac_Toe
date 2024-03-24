using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Handlers
{
    public static partial class ConsoleHandler
    {
        public static int GetInput(string prompt, Point init, int upperBound = 3)
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
            Console.SetCursorPosition(init.X, init.Y);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(init.X, init.Y);
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

        public static void ClearCurrentLine()
        {
            Point startPosition = new(Console.CursorLeft, Console.CursorTop);
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, startPosition.Y);
        }

        public static void ClearSelectedLine(int row) 
        {
            Console.SetCursorPosition(0, row);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, row);
        }

        public static void WriteOverLine(string message, Point position)
        {
            SetCursorPoint(position);
            Console.Write(new string(' ', Console.WindowWidth));
            SetCursorPoint(position);
            Console.Write(message);
        }

        public static void SetCursorPoint(Point position) 
        { 
            Console.SetCursorPosition(position.X, position.Y); 
        }

    }
}
