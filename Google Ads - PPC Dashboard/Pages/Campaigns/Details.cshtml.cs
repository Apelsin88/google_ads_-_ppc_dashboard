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

        //public IList<Campaign> Campaign { get; set; } = default!;
        public Campaign Campaign { get; set; } = default!;

        public DetailsModel(ICampaignService campaginService)
        {
            CampaignService = campaginService;
        }

        //public async Task<IActionResult> OnGetAsync(int id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var campaign = await CampaignService.GetCampaignByIdAsync(id);
        //    if (campaign == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        Campaign = (IList<Campaign>) campaign;
        //    }
        //    return Page();
        //}
        public async Task<IActionResult> OnGetAsync(int id)
        {

            Campaign = await CampaignService.GetCampaignByIdAsync(id);

            return Page();
        }
    }
}
