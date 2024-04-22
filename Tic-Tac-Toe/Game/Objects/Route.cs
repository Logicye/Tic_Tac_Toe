using ConsoleGameFramework.Objects.Vectors;

namespace Tic_Tac_Toe.Game.Objects
{
	public struct Route
	{
		private readonly Vector2 currentPosition;
		private readonly Vector2 targetPosition;
		public List<Vector2> PathToTarget;

		public Route(Vector2 current, Vector2 target) { 
			currentPosition = current; 
			targetPosition = target; 
			PathToTarget = GeneratePath();
		}

		public List<Vector2> GeneratePath()
		{
			List<Vector2> result = new List<Vector2>();
			return result;
		}
	}
}
