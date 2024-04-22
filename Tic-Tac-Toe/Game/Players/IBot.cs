using ConsoleGameFramework.Objects.Vectors;
using Tic_Tac_Toe.Game.Objects;

namespace Tic_Tac_Toe.Game.Players
{
    public interface IBot
    {
		public delegate void CallMove();
		public static event CallMove? MoveUp;
		public static event CallMove? MoveDown;
		public static event CallMove? MoveLeft;
		public static event CallMove? MoveRight;
		public static event CallMove? MakeMove;

		public Route Route { get; }
		public Vector2 NextMove();
		public Route NewRoute(Vector2 current, Vector2 target);
		
		public async Task ExecuteRoute()
		{
			foreach(Vector2 move in Route.PathToTarget)
			{
				if (move == (move + Vector2.Left)) MoveLeft?.Invoke();
				if (move == (move + Vector2.Right)) MoveRight?.Invoke();
				if (move == (move + Vector2.Up)) MoveUp?.Invoke();
				if (move == (move + Vector2.Down)) MoveDown?.Invoke();

			}
			MakeMove?.Invoke();
		}

		public void RegisterInput(ComputerPlayer player)
		{
			MoveUp    += player.MoveUp;
			MoveDown  += player.MoveDown;
			MoveLeft  += player.MoveLeft;
			MoveRight += player.MoveRight;
			MakeMove  += player.MakeMove;
		}

		public void UnregisterInput(ComputerPlayer player)
		{
			MoveUp    -= player.MoveUp;
			MoveDown  -= player.MoveDown;
			MoveLeft  -= player.MoveLeft;
			MoveRight -= player.MoveRight;
			MakeMove  -= player.MakeMove;
		}
	}
}
 