using ConsoleGameFramework.Objects.Vectors;
using Tic_Tac_Toe.Game.Objects;

namespace Tic_Tac_Toe.Game.Players.Bots
{
	internal class MediumBot : IBot
	{
		public Route Route { get; private set; }

		public void ExecuteRoute()
		{
			throw new NotImplementedException();
		}

		public Route NewRoute(Vector2 current, Vector2 target)
		{
			throw new NotImplementedException();
		}

		public Vector2 NextMove()
		{
			throw new NotImplementedException();
		}
	}
}
