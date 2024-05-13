using ConsoleGameFramework.Objects.Assets.Menu;
using Tic_Tac_Toe.Game.Players;
using Tic_Tac_Toe.Game;

namespace Tic_Tac_Toe;

internal static class Menus
{
	private static Menu onlinePlayMenu = new(
		"Online Play Options",
		new List<MenuItem> {
			new MenuItem("Host Game", () => throw new NotImplementedException()),
			new MenuItem("Connect To Game", () => throw new NotImplementedException()),
			new MenuItem("Search For Online Game", () => throw new NotImplementedException())
		});
	private static Menu multiPlayerMenu = new(
		"Multiplayer",
		new List<MenuItem> {
			new MenuItem("Local Multiplayer", () => new StandardGame(new HumanPlayer(), new HumanPlayer(false))),
			new MenuItem("Online Multiplayer", onlinePlayMenu)
		});
	private static Menu singlePlayerMenu = new(
		"SinglePlayer",
		new List<MenuItem> {
			new MenuItem("Easy", () => new StandardGame(new HumanPlayer(), new ComputerPlayer(0))),
			new MenuItem("Medium", () => new StandardGame(new HumanPlayer(), new ComputerPlayer(1))),
			new MenuItem("Hard", () => new StandardGame(new HumanPlayer(), new ComputerPlayer(2))),
			new MenuItem("Experimental AI", () => new StandardGame(new HumanPlayer(), new ComputerPlayer(3)))
		});
	private static Menu mainMenu = new(
		"Main Menu",
		new List<MenuItem>
		{
			new MenuItem("Singeplayer", singlePlayerMenu),
			new MenuItem("Multiplayer", multiPlayerMenu)
		});
	public static Menu GetRoot => mainMenu;
}
