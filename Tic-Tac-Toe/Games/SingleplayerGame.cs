using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Games.Bots;

namespace Tic_Tac_Toe.Games
{
    internal class SingleplayerGame : Game
    {
        Bot bot;
        public SingleplayerGame() 
        {
            bot = new EasyBot();
        }
    }
}
