using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Services;
using Google.Api;

namespace Google_Ads___PPC_Dashboard.Pages.Campaigns
{
    public class CampaignsOverviewModel : PageModel
    {

        private readonly Google_Ads___PPC_Dashboard.Services.ICampaignService? CampaignService;

        private readonly Google_Ads___PPC_Dashboard.Services.IAdService? AdService;

        public IList<Campaign> Campaigns { get; set; } = default!;

        public decimal AllConversions { get; set; } = default!;

        public decimal AvgROAS { get; set; } = default!;

        public CampaignsOverviewModel(ICampaignService campaginService, IAdService adService)
        {
            CampaignService = campaginService;
            AdService = adService;
        }

        public async Task OnGetAsync()
        {
            Campaigns = (IList<Campaign>)await CampaignService.GetAllCampaignsAsync();

            decimal roasSum = 0;
            foreach (Campaign campaign in Campaigns)
            {
                AllConversions += campaign.GetConversions();
                roasSum += campaign.GetROAS();
            }
            AvgROAS = roasSum / Campaigns.Count;

        }
    }
}
