using ConsoleGameFramework.Objects.Menu;

namespace Tic_Tac_Toe.Menus
{
	static class OnlinePlayMenu
	{
		private static readonly List<Option> _options = new List<Option>
		{
			new ("Host Game", () => throw new NotImplementedException()),
			new ("Connect To Game", () => throw new NotImplementedException()),
			new ("Search For Online Game", () => throw new NotImplementedException())
		};
		private static ConsoleMenu _menu = new("Online Play Options", _options);

		public static void Invoke()
		{
			_menu.Show(true);
		}
	}
}
