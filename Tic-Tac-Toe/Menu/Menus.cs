namespace Tic_Tac_Toe.Menu
{
	static class Menus
	{
		public static void MainMenu()
		{
			string menuName = "Tic - Tac - Toe";
			List<Menu.Option> menuOptions = new List<Menu.Option>
			{
				new Menu.Option("Singleplayer", () => SinglePlayerMenu()),
				new Menu.Option("Multiplayer", () => MultiPlayerMenu()),
				new Menu.Option("Exit", () => Environment.Exit(0))
			};
			Menu menu = new Menu(menuName, menuOptions);
			//menu.InitializeFrame();
		}
		public static void SinglePlayerMenu()
		{
			string menuName = "Singeplayer";
			List<Menu.Option> menuOptions = new List<Menu.Option>
			{
				new Menu.Option("Easy", () => throw new NotImplementedException()),
				new Menu.Option("Medium", () => throw new NotImplementedException()),
				new Menu.Option("Hard", () => throw new NotImplementedException()),
				new Menu.Option("Experimental AI", () => throw new NotImplementedException()),
				new Menu.Option("Return", () => MainMenu())
			};
			Menu menu = new Menu(menuName, menuOptions);
			//menu.InitializeFrame();
		}
		public static void MultiPlayerMenu()
		{
			string menuName = "Multiplayer";
			List<Menu.Option> menuOptions = new List<Menu.Option>
			{
				new Menu.Option("Local Multiplayer", () => throw new NotImplementedException()),
				new Menu.Option("Online Multiplayer", () => OnlinePlayMenu()),
				new Menu.Option("Return", () => MainMenu())
			};
			Menu menu = new Menu(menuName, menuOptions);
			//menu.InitializeFrame();
		}

		public static void OnlinePlayMenu()
		{
			string menuName = "Online Play Options";
			List<Menu.Option> menuOptions = new List<Menu.Option>
			{
				new Menu.Option("Host Game", () => throw new NotImplementedException()),
				new Menu.Option("Connect To Game", () => throw new NotImplementedException()),
				new Menu.Option("Search For Online Game", () => throw new NotImplementedException()),
				new Menu.Option("Return", () => MultiPlayerMenu())
			};
			Menu menu = new Menu(menuName, menuOptions);
			//menu.InitializeFrame();
		}
	}
}
