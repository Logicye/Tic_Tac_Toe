using ConsoleGameFramework.Objects.Menu;

namespace Tic_Tac_Toe.Menus
{
	static class MainMenu
	{
		private static Header _header = new("Tic - Tac - Toe");
		private static readonly List<Option> _options = new List<Option> 
		{
			new ("Singleplayer", () => SinglePlayerMenu.Invoke()),
			new ("Multiplayer", () => MultiPlayerMenu.Invoke()),
			new ("Exit", () => Environment.Exit(0))
		};
		private static ConsoleMenu _menu = new(_header, _options);

		public static void Invoke()
		{
			_menu.Initialize();
		}
	}
}
