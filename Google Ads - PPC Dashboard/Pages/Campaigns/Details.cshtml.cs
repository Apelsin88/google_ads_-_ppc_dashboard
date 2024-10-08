using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Google_Ads___PPC_Dashboard.Data;
using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Services;

namespace Google_Ads___PPC_Dashboard.Pages.Campaigns
{
    public class DetailsModel : PageModel
    {
        private readonly Google_Ads___PPC_Dashboard.Services.ICampaignService? CampaignService;
        private readonly Google_Ads___PPC_Dashboard.Services.IAdGroupService? AdGroupService;

        //public IList<Campaign> Campaign { get; set; } = default!;
        public Campaign Campaign { get; set; } = default!;
        public IList<AdGroup> AdGroups { get; set; } = default!;
        public IList<Ad> Ads { get; set; } = default!;

        public DetailsModel(ICampaignService campaginService, IAdGroupService adGroupService)
        {
            CampaignService = campaginService;
            AdGroupService = adGroupService;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {

            Campaign = await CampaignService.GetCampaignByIdAsync(id);
            AdGroups = (IList<AdGroup>) await AdGroupService.GetAllAdGroupsAsync();
            return Page();
        }
    }
}
