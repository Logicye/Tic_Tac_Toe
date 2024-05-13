using ConsoleGameFramework.Objects.Vectors;
using Tic_Tac_Toe.Game.Players.Bots;

namespace Tic_Tac_Toe.Game.Players
{
	public class ComputerPlayer : IPlayer
	{
		private IBot _bot;
		public char PlayerCharacter { get; }

		public bool ActivePlayer { get; private set; }

		public Vector2 CursorPositon { get; private set; }

		public ComputerPlayer(int botDifficulty, bool player1 = false)
		{
			if (player1)
			{
				PlayerCharacter = 'X';
				ActivePlayer = true;
			}
			else
			{
				PlayerCharacter = 'O';
				ActivePlayer = false;
			}
			switch (botDifficulty)
			{
				case 3:		_bot = new AiBot();		break;
				case 2:		_bot = new HardBot();	break;
				case 1:		_bot = new MediumBot(); break;
				default:	_bot = new EasyBot();	break;
			}
			CursorPositon = Vector2.One;
			_bot.RegisterInput(this);
		}

		public void MakeMove()
		{
			IPlayer.CallUpdate();
		}

		public void MoveDown()
		{
			CursorPositon += Vector2.Down;
			IPlayer.CallUpdate();
		}

		public void MoveLeft()
		{
			CursorPositon += Vector2.Left;
			IPlayer.CallUpdate();
		}

		public void MoveRight()
		{
			CursorPositon += Vector2.Right;
			IPlayer.CallUpdate();
		}

		public void MoveUp()
		{
			CursorPositon += Vector2.Up;
			IPlayer.CallUpdate();
		}
	}
}
