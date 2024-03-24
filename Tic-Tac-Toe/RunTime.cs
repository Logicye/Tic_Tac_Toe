﻿namespace Tic_Tac_Toe
{
    internal class RunTime
    {
        static void Main()
        {
            MainMenu();
            Console.ReadKey();
        }

        private static Menu MainMenu()
        {
            return new("Tic - Tac - Toe",
                new KeyValuePair<string, Action>("Single Player", () => SinglePlayerMenu()),
                new KeyValuePair<string, Action>("Multiplayer", () => MultiPlayerMenu()),
                new KeyValuePair<string, Action>("Exit", () => Environment.Exit(0)));
        }

        private static Menu SinglePlayerMenu()
        {
            return new("Difficulty",
                new KeyValuePair<string, Action>("Easy", () => Console.WriteLine("1")),
                new KeyValuePair<string, Action>("Medium", () => Console.WriteLine("2")),
                new KeyValuePair<string, Action>("Hard", () => Console.WriteLine("3")),
                new KeyValuePair<string, Action>("Return", () => MainMenu()));
        }

        private static Menu MultiPlayerMenu()
        {
            return new("Multiplayer",
                new KeyValuePair<string, Action>("Local Play", () => new Game()),
                new KeyValuePair<string, Action>("Online Play", () => OnlinePlayMenu()),
                new KeyValuePair<string, Action>("Return", () => MainMenu()));
        }

        private static Menu OnlinePlayMenu()
        {
            return new("Online Play",
                new KeyValuePair<string, Action>("Host Game", () => Console.WriteLine("1")),
                new KeyValuePair<string, Action>("Connect To Game", () => Console.WriteLine("2")),
                new KeyValuePair<string, Action>("Return", () => MultiPlayerMenu()));
        }
    }
}