using ConsoleGameFramework.Objects.Vectors;

namespace Tic_Tac_Toe.Game.Players
{
    internal interface IPlayer
    {
		public delegate void UpdateEvent();
		public static event UpdateEvent? UpdateCall;
		public char PlayerCharacter {  get; }
        public bool ActivePlayer { get; }
        public Vector2 CursorPositon { get; }
        public void MoveLeft();
        public void MoveRight();
        public void MoveUp();
        public void MoveDown();
        public void MakeMove();
		public static void CallUpdate()
		{
			IPlayer.UpdateCall?.Invoke();
		}


	}
}
