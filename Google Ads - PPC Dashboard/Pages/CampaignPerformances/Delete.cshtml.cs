using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Google_Ads___PPC_Dashboard.Data;
using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Pages.CampaignPerformances
{
    public class DeleteModel : PageModel
    {
        private readonly Google_Ads___PPC_Dashboard.Data.Google_Ads___PPC_DashboardContext _context;

        public DeleteModel(Google_Ads___PPC_Dashboard.Data.Google_Ads___PPC_DashboardContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CampaignPerformance CampaignPerformance { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaignperformance = await _context.CampaignPerformances.FirstOrDefaultAsync(m => m.Id == id);

            if (campaignperformance == null)
            {
                return NotFound();
            }
            else
            {
                CampaignPerformance = campaignperformance;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var campaignperformance = await _context.CampaignPerformances.FindAsync(id);
            if (campaignperformance != null)
            {
                CampaignPerformance = campaignperformance;
                _context.CampaignPerformances.Remove(CampaignPerformance);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
