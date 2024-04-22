using ConsoleGameFramework.Objects.Menu;

namespace Tic_Tac_Toe.Menus
{
	static class MainMenu
	{
		private static readonly List<Option> _options = new List<Option> 
		{
			new ("Singleplayer", () => SinglePlayerMenu.Invoke()),
			new ("Multiplayer", () => MultiPlayerMenu.Invoke())
		};
		private static ConsoleMenu _menu = new("Tic - Tac - Toe", _options, true);

		public static void Invoke()
		{
			_menu.Show(true);
		}
	}
}
