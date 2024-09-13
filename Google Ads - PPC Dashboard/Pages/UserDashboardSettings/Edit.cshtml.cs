using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Google_Ads___PPC_Dashboard.Data;
using Google_Ads___PPC_Dashboard.Models;

namespace Google_Ads___PPC_Dashboard.Pages.UserDashboardSettings
{
    public class EditModel : PageModel
    {
        private readonly Google_Ads___PPC_Dashboard.Data.Google_Ads___PPC_DashboardContext _context;

        public EditModel(Google_Ads___PPC_Dashboard.Data.Google_Ads___PPC_DashboardContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UserDashboardSetting UserDashboardSetting { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userdashboardsetting =  await _context.UserDashboardSettings.FirstOrDefaultAsync(m => m.Id == id);
            if (userdashboardsetting == null)
            {
                return NotFound();
            }
            UserDashboardSetting = userdashboardsetting;
           ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(UserDashboardSetting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserDashboardSettingExists(UserDashboardSetting.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool UserDashboardSettingExists(int id)
        {
            return _context.UserDashboardSettings.Any(e => e.Id == id);
        }
    }
}
