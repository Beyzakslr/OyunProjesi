using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProjesi
{
    class CampaignManager : IOrderService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kapmanya Listesinden Silindi " );
        }

        public void Save(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kapmanya Listesine Kaydedildi ");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Kapmanya Listesi Güncellendi ");
        }
    }
}
