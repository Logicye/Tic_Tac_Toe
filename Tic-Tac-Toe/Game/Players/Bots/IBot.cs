using ConsoleGameFramework.Objects.Vectors;
using Tic_Tac_Toe.Game.Objects;

namespace Tic_Tac_Toe.Game.Players.Bots;

internal interface IBot
{
    public ComputerPlayer Player { get; }
    public Vector2 Target { get; }
    //Finds the next move to make based on the bots logic and sets the target to the new square
    public void NextMove(Cell[,] gameBoard);
    public void EmulateBotMove();
}
