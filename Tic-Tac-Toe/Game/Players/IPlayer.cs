using ConsoleGameFramework.Objects.Vectors;
using ConsoleGameFramework.Objects;

namespace Tic_Tac_Toe.Game.Players
{
    internal interface IPlayer : IUpdateEventCall
    {
		public char PlayerCharacter {  get; }
        public bool ActivePlayer { get; }
        public Vector2 CursorPositon { get; }
        public void MoveLeft();
        public void MoveRight();
        public void MoveUp();
        public void MoveDown();
        public void MakeMove();
	}
}
