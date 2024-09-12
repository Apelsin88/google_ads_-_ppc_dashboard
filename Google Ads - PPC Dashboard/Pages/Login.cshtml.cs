using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Google_Ads___PPC_Dashboard.Pages
{
    public class LoginModel : PageModel
    {
        public int userSum = 0;

        //public IList<ApplicationUser> users { get; set; } = default!;
        
        private readonly ApplicationUserService UserService;

        public LoginModel(ApplicationUserService userService)
        {
            UserService = userService;
        }

        public void OnGet()
        {
            
        }

        //public async Task OnGetAsync()
        //{
        //    users = (IList<ApplicationUser>)await UserService.GetAllApplicationUsersAsync();
        //}
    }
}
