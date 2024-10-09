using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Google_Ads___PPC_Dashboard.Data;
using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Pages.AdGroups
{
    public class CreateModel : PageModel
    {
        private readonly Google_Ads___PPC_Dashboard.Data.Google_Ads___PPC_DashboardContext _context;

        public CreateModel(Google_Ads___PPC_Dashboard.Data.Google_Ads___PPC_DashboardContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AdGroup AdGroup { get; set; } = default!;

        public IActionResult OnGet(int CampaignId)
        {
            // Set the AdGroupId for the new Ad
            AdGroup = new AdGroup
            {
                CampaignId = CampaignId
            };


            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Hämta kampanjen baserat på CampaignId innan ModelState valideras
            var campaign = await _context.Campaigns.FindAsync(AdGroup.CampaignId);
            if (campaign == null)
            {
                // Lägg till ett felmeddelande om kampanjen inte hittas
                return Page();
            }
            else
            {
                // Sätt navigationsobjektet Campaign om kampanjen hittas
                AdGroup.Campaign = campaign;
            }

            // Kontrollera om ModelState är giltigt efter att vi har satt Campaign
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AdGroups.Add(AdGroup);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Campaigns/Details", new { id = campaign.Id });

        }
    }
}
