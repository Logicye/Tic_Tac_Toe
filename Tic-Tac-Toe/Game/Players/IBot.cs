using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Game.Players
{
    public interface IBot
    {
		public Vector2 GetBestMove();
		public void PathFind();
		public void PathExecute();

	}
}
