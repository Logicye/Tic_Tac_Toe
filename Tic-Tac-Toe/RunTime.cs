using ConsoleGameFramework.Input.ReadKey;
using ConsoleGameFramework.Objects.Assets.Menu;

namespace Tic_Tac_Toe;

class RunTime
{
    static void Main()
    {
		IMenuType menuType = new FramedMenuType();
        ReadKeyStaticAsync.Start();
        MenuHandler GameMenu = new(Menus.GetRoot, menuType);
	}
}