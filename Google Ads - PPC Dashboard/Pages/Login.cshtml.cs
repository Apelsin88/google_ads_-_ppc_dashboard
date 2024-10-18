using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Google_Ads___PPC_Dashboard.Services;
using Google_Ads___PPC_Dashboard.Models;
using Microsoft.CodeAnalysis.Scripting;

namespace Google_Ads___PPC_Dashboard.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IApplicationUserService UserService;

        public LoginModel(IApplicationUserService userService)
        {
            UserService = userService;
        }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; } = default!;

        public void OnGet()
        {
            // Clear session or authentication cookies
            HttpContext.Session.Clear(); // Clear the session if using session-based authentication
            //return RedirectToPage("/Login"); // Redirect to the login page
        }

        //public IList<ApplicationUser> users { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await UserService.AuthenticateUserAsync(Email, Password);
            if (user == null)
            {
                ErrorMessage = "Invalid login attempt.";
                return Page();
            }

            // Create session after successful authentication
            HttpContext.Session.SetString("UserId", user.Id.ToString());
            HttpContext.Session.SetString("UserEmail", user.Email);
            HttpContext.Session.SetString("UserUsername", user.Username);

            // Handle the login success (you may set a session or generate a token here)
            return RedirectToPage("/index");
        }
    }
}