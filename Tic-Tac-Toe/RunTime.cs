using ConsoleGameFramework.Input.ReadKey;
using Tic_Tac_Toe.Menus;

namespace Tic_Tac_Toe
{
    class RunTime
    {
        static void Main()
        {
            ReadKeyStaticAsync.Start();
            MainMenu.Invoke();
		}
    }
}  