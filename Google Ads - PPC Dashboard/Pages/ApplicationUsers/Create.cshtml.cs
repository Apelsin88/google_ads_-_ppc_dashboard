using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Services;

namespace Google_Ads___PPC_Dashboard.Pages.ApplicationUsers
{
    public class CreateModel : PageModel
    {
        private readonly IApplicationUserService _applicationUserService;

        public CreateModel(IApplicationUserService applicationUserService)
        {
            _applicationUserService = applicationUserService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ApplicationUser ApplicationUser { get; set; } = new ApplicationUser();

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _applicationUserService.AddApplicationUserAsync(ApplicationUser);

            return RedirectToPage("./Index");
        }
    }
}
