using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
