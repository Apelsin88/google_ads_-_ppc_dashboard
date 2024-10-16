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

        private readonly Google_Ads___PPC_Dashboard.Services.ICampaignPerformanceService? CampaignPerformanceService;



        public IList<Campaign> Campaigns { get; set; } = default!;

        public IList<CampaignPerformance> campaignPerformances { get; set; } = default!;


        public decimal AllConversions { get; set; } = default!;

        public decimal AvgROAS { get; set; } = default!;



        public CampaignsOverviewModel(ICampaignService campaginService, IAdService adService, ICampaignPerformanceService campaignPerformanceService)
        {
            CampaignService = campaginService;
            AdService = adService;
            CampaignPerformanceService = campaignPerformanceService;
        }

        public async Task<IActionResult> OnGetAsync()
        {

            // Check if the user is authenticated by checking the session
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserId")))
            {
                // If no UserId is found in the session, redirect to the login page
                return RedirectToPage("/Login");
            }

            // If authenticated, proceed with the rest of the logic


            campaignPerformances = (IList<CampaignPerformance>)await CampaignPerformanceService.GetAllPerformancesAsync();

            Campaigns = (IList<Campaign>)await CampaignService.GetAllCampaignsAsync();

            decimal roasSum = 0;
            foreach (Campaign campaign in Campaigns)
            {
                AllConversions += campaign.GetConversions();
                roasSum += campaign.GetROAS();
            }
            AvgROAS = roasSum / Campaigns.Count;

            return Page();
        }

    }
}
