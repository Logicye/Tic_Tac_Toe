using ConsoleGameFramework.Input.ReadKey;
using ConsoleGameFramework.Objects.Assets.Menu;

namespace Tic_Tac_Toe;

class RunTime
{
	public static MenuHandler? GameMenu;

	static void Main()
    {
		GameMenu = new(Menus.GetRoot, new FramedMenuType());
        ReadKeyStaticAsync.Start();
	}
}