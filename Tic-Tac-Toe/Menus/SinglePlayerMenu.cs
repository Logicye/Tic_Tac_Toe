﻿using ConsoleGameFramework.Objects.Menu;
using Tic_Tac_Toe.Game.Players;
using Tic_Tac_Toe.Game;

namespace Tic_Tac_Toe.Menus
{
	static class SinglePlayerMenu
	{
		private static readonly List<Option> _options = new List<Option> 
		{
			new ("Easy", () => new StandardGame(new HumanPlayer(), new ComputerPlayer(0))),
			new ("Medium", () => new StandardGame(new HumanPlayer(), new ComputerPlayer(1))),
			new ("Hard", () => new StandardGame(new HumanPlayer(), new ComputerPlayer(2))),
			new ("Experimental AI", () => new StandardGame(new HumanPlayer(), new ComputerPlayer(3)))
		};
		private static ConsoleMenu _menu = new("Singeplayer", _options);

		public static void Invoke()
		{
			_menu.Show(true);
		}
	}
}
