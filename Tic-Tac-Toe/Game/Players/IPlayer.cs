using ConsoleGameFramework.Objects.Vectors;

namespace Tic_Tac_Toe.Games.PlayerObjects
{
    internal interface IPlayer
    {
        public char PlayerCharacter {  get; }
        public bool ActivePlayer { get; set; }
        public Vector2 CursorPosiiton { get; }
        public void MoveLeft();
        public void MoveRight();
        public void MoveUp();
        public void MoveDown();
        public void MakeMove();


    }
}
