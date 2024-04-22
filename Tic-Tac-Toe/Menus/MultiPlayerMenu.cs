using ConsoleGameFramework.Objects.Menu;
using Tic_Tac_Toe.Game.Players;
using Tic_Tac_Toe.Game;

namespace Tic_Tac_Toe.Menus
{
	static class MultiPlayerMenu
	{
		private static readonly List<Option> _options = new List<Option>
		{
			new ("Local Multiplayer", () => new TTT_Game(new HumanPlayer(), new HumanPlayer(false))),
			new ("Online Multiplayer", () => OnlinePlayMenu.Invoke())
		};
		private static ConsoleMenu _menu = new("Multiplayer", _options);

		public static void Invoke()
		{
			_menu.Show(true);
		}
	}		
	
}
