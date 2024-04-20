using Tic_Tac_Toe.Handlers;
using Tic_Tac_Toe.Menu;

namespace Tic_Tac_Toe
{
	class RunTime
	{
		static void Main()
		{
			ConsoleKeyboardEventHandler.Start();
			Menus.MainMenu();
		}
	}
}