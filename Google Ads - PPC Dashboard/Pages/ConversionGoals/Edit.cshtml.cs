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

namespace Google_Ads___PPC_Dashboard.Pages.ConversionGoals
{
    public class EditModel : PageModel
    {
        private readonly Google_Ads___PPC_Dashboard.Data.Google_Ads___PPC_DashboardContext _context;

        public EditModel(Google_Ads___PPC_Dashboard.Data.Google_Ads___PPC_DashboardContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ConversionGoal ConversionGoal { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conversiongoal =  await _context.ConversionGoals.FirstOrDefaultAsync(m => m.ConversionGoalId == id);
            if (conversiongoal == null)
            {
                return NotFound();
            }
            ConversionGoal = conversiongoal;
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

            _context.Attach(ConversionGoal).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConversionGoalExists(ConversionGoal.ConversionGoalId))
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

        private bool ConversionGoalExists(int id)
        {
            return _context.ConversionGoals.Any(e => e.ConversionGoalId == id);
        }
    }
}
