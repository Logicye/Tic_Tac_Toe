using ConsoleGameFramework.Input.ReadKey;
using Tic_Tac_Toe.Game.Players;
using Tic_Tac_Toe.Game;
using Tic_Tac_Toe.Menus;
using ConsoleGameFramework.Objects;

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