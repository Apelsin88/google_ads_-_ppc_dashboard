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

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Ads.Add(Ad);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}