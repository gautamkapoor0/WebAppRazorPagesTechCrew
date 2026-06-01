using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPagesTechCrew.Pages
{
    public class SubModel : PageModel
    {
        [BindProperty]
        public int num1 { get; set; }

        [BindProperty]
        public int num2 { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {

            TempData["res"] = num1 - num2;
        }
    }
}
