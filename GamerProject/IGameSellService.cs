using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    interface IGameSellService 
    {
        void Sell(Gamer gamer, Game game);
    }
}
