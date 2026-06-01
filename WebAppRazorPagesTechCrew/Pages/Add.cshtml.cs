using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPagesTechCrew.Pages
{
    public class AddModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost()
        {
            int x =Convert.ToInt32( Request.Form["num1"].ToString());

            int y = Convert.ToInt32(Request.Form["num2"].ToString());

            TempData["res"] = x + y;
        }
    }
}
