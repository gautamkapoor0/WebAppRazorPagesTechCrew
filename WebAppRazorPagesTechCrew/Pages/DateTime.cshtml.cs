using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPagesTechCrew.Pages
{
    public class DateTimeModel : PageModel
    {
        public void OnGet()
        {
            // as  soon as page loads , onget fun executes

            TempData["CurrentDateTime"] = "On Load:" + DateTime.Now.ToLongDateString();
            TempData["time"] = "On Load:" + DateTime.Now.ToLongTimeString();     
        }

        public void OnPost()
        {
            // as  soon as page loads , onpost fun executes
            TempData["CurrentDateTime"] ="On submit:"+ DateTime.Now.ToLongDateString();
            TempData["time"] = "On submit:" + DateTime.Now.ToLongTimeString();
        }   
    }
}
