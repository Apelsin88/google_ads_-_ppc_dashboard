using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Google_Ads___PPC_Dashboard.Pages
{
    public class LoginModel : PageModel
    {
        /// Funkar med IApplicationUserService men inte med en vanlig ApplicationUserService
        public int userSum = 0;
        private readonly Google_Ads___PPC_Dashboard.Services.IApplicationUserService? UserService;

        public LoginModel(IApplicationUserService userService)
        {
            UserService = userService;
        }

        public IList<ApplicationUser> users { get; set; } = default!;
        public async Task OnGetAsync()
        {
            users = (IList<ApplicationUser>)await UserService.GetAllApplicationUsersAsync();
        }
    }
}
