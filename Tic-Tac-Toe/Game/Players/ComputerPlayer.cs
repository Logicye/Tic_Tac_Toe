using System.Drawing;

namespace Tic_Tac_Toe.Games.PlayerObjects
{
	internal class ComputerPlayer : IPlayer
	{
		public char PlayerCharacter { get; }

		public bool ActivePlayer { get; set; }

		public Point CursorPosiiton { get; set; }

		public void PlayerControl()
		{
			throw new NotImplementedException();
		}
	}
}
