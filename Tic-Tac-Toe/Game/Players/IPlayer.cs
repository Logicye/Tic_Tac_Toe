using System.Drawing;

namespace Tic_Tac_Toe.Games.PlayerObjects
{
	internal interface IPlayer
	{
		public char PlayerCharacter { get; }
		public bool ActivePlayer { get; set; }
		public Point CursorPosiiton { get; }
		public void PlayerControl();


	}
}
