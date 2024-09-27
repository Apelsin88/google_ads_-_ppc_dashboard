using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Services;

namespace Google_Ads___PPC_Dashboard.Pages.Campaigns
{
    public class CampaignsOverviewModel : PageModel
    {
        private readonly Google_Ads___PPC_Dashboard.Services.ICampaignService? CampaignService;

        public IList<Campaign> Campagins { get; set; } = default!;

        public CampaignsOverviewModel(ICampaignService campaginService)
        {
            CampaignService = campaginService;
        }

        
        public async Task OnGetAsync()
        {
            Campagins = (IList<Campaign>)await CampaignService.GetAllCampaignsAsync();
        }
    }
}
