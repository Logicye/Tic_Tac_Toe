namespace Tic_Tac_Toe.Handlers
{
	internal interface IConsoleEvents
	{
		void Register();
		void Unregister();
		void OnKeyPressed(ConsoleKey key);
	}
}
