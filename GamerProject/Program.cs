using System;

namespace GamerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Emre";
            gamer1.lastName = "Kara";
            gamer1.BrithYear = 1999;
            gamer1.IdentityNumber = 15815793818;
            
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BrithYear = 1999, FirstName = "Emre", lastName = "Kara", IdentityNumber = 15815793818 });


            Game game1 = new Game();
            game1.GameName = "forza horizon 4";
            game1.GamePrice = 200;


            GameSellServiceManager gameSellServiceManager = new GameSellServiceManager();
            gameSellServiceManager.Sell(gamer1,game1);

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Black Friday";

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
        }
    }
}
