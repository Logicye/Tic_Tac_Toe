﻿using ConsoleGameFramework.Objects;
using Tic_Tac_Toe.Game.Objects;
using Tic_Tac_Toe.Game.Players;

namespace Tic_Tac_Toe.Game
{
    internal class Game : IUpdateEvents
    {
		private IPlayer _player1;
		private IPlayer _player2;
		private Board _board;
		private GameState _state;

		public Game(IPlayer player1, IPlayer player2)
		{
			_player1 = player1;
			_player2 = player2;
			_board = new Board();
			_state = GameState.TurnPlayer1;
			Initialize();
		}

		public void Initialize()
		{
			Console.CursorVisible = false;
			_board.Initialize();
			_board.Update(_state, _player1, _player2);
			Register();
		}

		public void Register()
		{
			IPlayer.UpdateCall += Update;
		}

		public void Unregister()
		{
			IPlayer.UpdateCall -= Update;
		}

		public void Update()
		{
			_board.Update(_state, _player1, _player2);
		}

		public void GameOver() 
		{
			
		}

	}
}