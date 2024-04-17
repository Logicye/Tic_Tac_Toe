using System.IO;
using Tic_Tac_Toe.Menu;
using Tic_Tac_Toe.Handlers;

namespace Tic_Tac_Toe
{
    class RunTime
    {
        static async Task Main()
        {
            ConsoleKeyboardEventHandler.Start();
			Menus.MainMenu();
		}
    }
}  