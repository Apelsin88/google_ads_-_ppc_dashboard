using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Google_Ads___PPC_Dashboard.Data;
using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Pages.Campaigns
{
    public class CreateModel : PageModel
    {
        private readonly Google_Ads___PPC_DashboardContext _context;

        public CreateModel(Google_Ads___PPC_DashboardContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Campaign Campaign { get; set; } = new Campaign();

        public IActionResult OnGet()
        {
            return Page();
        }

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || Campaign == null)
            {
                return Page();
            }

            _context.Campaigns.Add(Campaign);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}