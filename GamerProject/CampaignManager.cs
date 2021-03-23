using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName +" Kampanyası Eklendi");
        }

        public void Delete(Campaign campaign)
        {
             Console.WriteLine("Silindi");
        }

        public void Update(Campaign campaign)
        {
             Console.WriteLine("Güncellendi");
        }
    }
}
