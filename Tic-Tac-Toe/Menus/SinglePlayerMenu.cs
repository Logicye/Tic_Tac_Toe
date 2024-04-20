using ConsoleGameFramework.Objects.Menu;

namespace Tic_Tac_Toe.Menus
{
	static class SinglePlayerMenu
	{
		private static Header _header = new("Singeplayer");
		private static readonly List<Option> _options = new List<Option> 
		{
			new ("Easy", () => throw new NotImplementedException()),
			new ("Medium", () => throw new NotImplementedException()),
			new ("Hard", () => throw new NotImplementedException()),
			new ("Experimental AI", () => throw new NotImplementedException()),
			new ("Return", () => MainMenu.Invoke())
		};
		private static ConsoleMenu _menu = new(_header, _options);

		public static void Invoke()
		{
			_menu.Initialize();
		}
	}
}
