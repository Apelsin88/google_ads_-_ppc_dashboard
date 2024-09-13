using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Google_Ads___PPC_Dashboard.Data;
using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Pages.Keywords
{
    public class DetailsModel : PageModel
    {
        private readonly Google_Ads___PPC_Dashboard.Data.Google_Ads___PPC_DashboardContext _context;

        public DetailsModel(Google_Ads___PPC_Dashboard.Data.Google_Ads___PPC_DashboardContext context)
        {
            _context = context;
        }

        public Keyword Keyword { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var keyword = await _context.Keywords.FirstOrDefaultAsync(m => m.Id == id);
            if (keyword == null)
            {
                return NotFound();
            }
            else
            {
                Keyword = keyword;
            }
            return Page();
        }
    }
}
