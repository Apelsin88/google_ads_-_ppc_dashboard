using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Google_Ads___PPC_Dashboard.Data;
using Google_Ads___PPC_Dashboard.Models;
using Google_Ads___PPC_Dashboard.Services;

namespace Google_Ads___PPC_Dashboard.Pages.ApplicationUsers
{
    public class CreateModel : PageModel
    {
        ApplicationUserService _applicationUserService;

        public CreateModel(ApplicationUserService applicationUserService)
        {
            _applicationUserService = applicationUserService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ApplicationUser ApplicationUser { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }
        //    _applicationUserService.AddApplicationUserAsync(ApplicationUser);
        //    return RedirectToPage("./Index");
        //}
    }
}
