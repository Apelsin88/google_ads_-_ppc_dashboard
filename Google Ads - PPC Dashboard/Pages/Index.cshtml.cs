using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Google_Ads___PPC_Dashboard.Pages
{
    public class IndexModel : PageModel
    {
        public string UserName { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            // Check if the user is authenticated by checking the session
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("UserId")))
            {
                // If no UserId is found in the session, redirect to the login page
                return RedirectToPage("/Login");
            }

            // If authenticated, proceed with the rest of the logic
            return Page();
        }

        //public IActionResult OnPostLogout()
        //{
        //    // Clear the session to log the user out
        //    HttpContext.Session.Clear();

        //    // Redirect to the login page after logout
        //    return RedirectToPage("/Login");
        //}
    }
}
