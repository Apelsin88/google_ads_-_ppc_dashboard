using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Google_Ads___PPC_Dashboard.Data;
using Google_Ads___PPC_Dashboard.Models;
using Microsoft.EntityFrameworkCore;
using Google.Api;

namespace Google_Ads___PPC_Dashboard.Pages.Ads
{
    public class CreateModel : PageModel
    {
        private readonly Google_Ads___PPC_Dashboard.Data.Google_Ads___PPC_DashboardContext _context;

        public CreateModel(Google_Ads___PPC_Dashboard.Data.Google_Ads___PPC_DashboardContext context)
        {
            _context = context;
        }


        [BindProperty]
        public Ad Ad { get; set; } = default!;

        public IActionResult OnGet(int AdGroupId)
        {
            // Set the AdGroupId for the new Ad
            Ad = new Ad
            {
                AdGroupId = AdGroupId
            };

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // H�mta kampanjen baserat p� CampaignId innan ModelState valideras
            var adGroup = await _context.AdGroups.FindAsync(Ad.AdGroupId);
            if (adGroup == null)
            {
                // L�gg till ett felmeddelande om kampanjen inte hittas
                return Page();
            }
            else
            {
                // S�tt navigationsobjektet Campaign om kampanjen hittas
                Ad.AdGroup = adGroup;
            }

            // Kontrollera om ModelState �r giltigt efter att vi har satt Campaign
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Ads.Add(Ad);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Campaigns/Details", new { id = adGroup.CampaignId });
        }

    }
}