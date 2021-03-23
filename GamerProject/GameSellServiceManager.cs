using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    class GameSellServiceManager : IGameSellService
    {
        public void Sell(Gamer gamer, Game game)
        {
            Console.WriteLine("Sevgili" + gamer.FirstName + "Almış olduğnuz " + game.GameName + " Oyununu iyi günlerde kullanınız" );
        }
    }
}
