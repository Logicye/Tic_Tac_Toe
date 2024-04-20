namespace Tic_Tac_Toe.DepricatedCode.Menu.Menus
{
	public class MainMenu : IMenu
	{
		public string Title { get; set; }
		public int SelectedIndex { get; set; }
		public List<IMenu.Option> Options { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }

		public MainMenu()
		{
			Title = "Tic - Tac - Toe";
			SelectedIndex = 0;
			Options = new List<IMenu.Option>
			{
				new IMenu.Option("SinglePlayer", () => new SinglePlayerMenu()),
				new IMenu.Option("MultiPlayer", () => new MultiPlayerMenu()),
				new IMenu.Option("Exit Game", () => Environment.Exit(0))
			};
		}

		public void Run()
		{

		}

		public void DisplayUpdate()
		{

		}

		public void GetInput()
		{

		}

		public void Invoke(IMenu.Option option)
		{
			option.Action.Invoke();
		}
	}
}
