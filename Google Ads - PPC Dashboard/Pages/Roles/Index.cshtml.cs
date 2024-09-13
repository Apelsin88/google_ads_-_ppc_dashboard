using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Google_Ads___PPC_Dashboard.Data;
using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Pages.Roles
{
    public class IndexModel : PageModel
    {
        private readonly Google_Ads___PPC_Dashboard.Data.Google_Ads___PPC_DashboardContext _context;

        public IndexModel(Google_Ads___PPC_Dashboard.Data.Google_Ads___PPC_DashboardContext context)
        {
            _context = context;
        }

        public IList<Role> Role { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Role = await _context.Roles.ToListAsync();
        }
    }
}
