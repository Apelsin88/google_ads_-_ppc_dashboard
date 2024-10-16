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

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public LoginModel(IApplicationUserService userService)
        {
            UserService = userService;
        }

        public IList<ApplicationUser> users { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Check if the user exists
            //var user = await UserService.GetUserByEmailAsync(Email);

            //if (user == null || !BCrypt.Net.BCrypt.Verify(Password, user.PasswordHash)) // Assuming passwords are hashed
            //{
            //    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            //    return Page();
            //}

            // Handle the login success (you may set a session or generate a token here)
            return RedirectToPage("/Dashboard");  // Assuming '/Dashboard' is your landing page after login
        }

        public async Task OnGetAsync()
        {
            users = (IList<ApplicationUser>)await UserService.GetAllApplicationUsersAsync();
        }
    }
}