using ConsoleGameFramework.Input.ReadKey;
using ConsoleGameFramework.Objects.Vectors;

namespace Tic_Tac_Toe.Game.Players
{
	public class HumanPlayer : IPlayer, IReadKeyEvents
	{
		public char PlayerCharacter { get; }

		public bool ActivePlayer { get; private set; }

		public Vector2 CursorPositon { get; private set; }

		public HumanPlayer (bool player1 = true) 
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
			CursorPositon = Vector2.One;
			Register();
        }

		public void MakeMove()
		{
			IPlayer.CallUpdate();
		}

		public void MoveDown()
		{
			if (CursorPositon.Y < 2)
			{ 
				CursorPositon -= Vector2.Down;
				IPlayer.CallUpdate();
			}
		}

		public void MoveLeft()
		{
			if (CursorPositon.X > 0)
			{
				CursorPositon += Vector2.Left;
				IPlayer.CallUpdate();
			}
		}

		public void MoveRight()
		{
			if (CursorPositon.X < 2)
			{ 
				CursorPositon += Vector2.Right;
				IPlayer.CallUpdate();
			}
		}

		public void MoveUp()
		{
			if (CursorPositon.Y > 0)
			{
				CursorPositon -= Vector2.Up;
				IPlayer.CallUpdate();
			}
		}

		public void Escape()
		{
			//ConsoleMenu.LastActive?.Show();
		}

		public void Register()
		{
			ReadKeyStaticAsync.KeyPressed += OnKeyPressed;
		}

		public void Unregister()
		{
			ReadKeyStaticAsync.KeyPressed -= OnKeyPressed;
		}

		public void OnKeyPressed(ConsoleKey key)
		{
			if (PlayerCharacter == 'X')
			{
				switch (key)
				{
					case ConsoleKey.W: MoveUp(); break;
					case ConsoleKey.S: MoveDown(); break;
					case ConsoleKey.D: MoveRight(); break;
					case ConsoleKey.A: MoveLeft(); break;
					case ConsoleKey.Escape: break;
				}
			}
			else
			{
				switch (key)
				{
					case ConsoleKey.UpArrow: MoveUp(); break;
					case ConsoleKey.DownArrow: MoveDown(); break;
					case ConsoleKey.RightArrow: MoveRight(); break;
					case ConsoleKey.LeftArrow: MoveLeft(); break;
					case ConsoleKey.Escape: break;
				}
			}
			
		}
	}
}
