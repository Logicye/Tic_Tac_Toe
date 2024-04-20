﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Games.Players.Bots;

namespace Tic_Tac_Toe.Games
{
    internal class SingleplayerGame : Game
    {
        IBot bot;
        public SingleplayerGame() 
        {
            bot = new EasyBot();
        }
    }
}
