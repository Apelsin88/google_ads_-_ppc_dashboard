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
    public class DeleteModel : PageModel
    {
        private readonly Google_Ads___PPC_Dashboard.Data.Google_Ads___PPC_DashboardContext _context;

        public DeleteModel(Google_Ads___PPC_Dashboard.Data.Google_Ads___PPC_DashboardContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Keyword Keyword { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            // Check if the user is authenticated by checking the session
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserId")))
            {
                // If no UserId is found in the session, redirect to the login page
                return RedirectToPage("/Login");
            }

            // If authenticated, proceed with the rest of the logic

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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var keyword = await _context.Keywords.FindAsync(id);
            if (keyword != null)
            {
                Keyword = keyword;
                _context.Keywords.Remove(Keyword);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
