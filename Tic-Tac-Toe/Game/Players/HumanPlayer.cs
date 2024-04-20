using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Games.PlayerObjects
{
	internal class HumanPlayer : IPlayer
	{
		public char PlayerCharacter { get; }
		public bool ActivePlayer { get; set; }
		public Point CursorPosiiton { get; }

		public HumanPlayer(char playerCharacter)
		{
			this.PlayerCharacter = playerCharacter;
			if (playerCharacter == 'X') { this.ActivePlayer = true; } else { this.ActivePlayer = false; }
			this.CursorPosiiton = new Point(1, 1);
		}

		public void CursorController()
		{
			
		}

		public void PlayerControl()
		{
			
		}

		public Point PlayerMove()
		{
			return new Point(0, 0);
		}
	}
}
