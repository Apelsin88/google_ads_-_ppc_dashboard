using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Google_Ads___PPC_Dashboard.Pages
{
    public class BasePageModel : PageModel
    {
        public string UserId { get; set; }

        // This method is called before the page handler executes
        public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            UserId = HttpContext.Session.GetString("UserId"); // Retrieves the user ID from the session
            base.OnPageHandlerExecuting(context);
        }
    }
}
