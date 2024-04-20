using ConsoleGameFramework.Objects.Menu;

namespace Tic_Tac_Toe.Menus
{
	static class MultiPlayerMenu
	{
		private static Header _header = new("Multiplayer");
		private static readonly List<Option> _options = new List<Option>
		{
			new ("Local Multiplayer", () => throw new NotImplementedException()),
			new ("Online Multiplayer", () => OnlinePlayMenu.Invoke()),
			new ("Return", () => MainMenu.Invoke())
		};
		private static ConsoleMenu _menu = new(_header, _options);

		public static void Invoke()
		{
			_menu.Show();
		}
	}		
	
}
