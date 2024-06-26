﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Games;

namespace Tic_Tac_Toe.Menu
{
    internal class Menus
    {
        public static Menu MainMenu()
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
                new KeyValuePair<string, Action>("Local Play", () => new Games.Game()),
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
