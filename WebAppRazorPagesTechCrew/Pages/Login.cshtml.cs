using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesTechCrew.Models;

namespace WebAppRazorPagesTechCrew.Pages
{
    public class LoginModel : PageModel
    {
        public AppDb _db;
        public LoginModel()
        {
            _db = new AppDb();
        }


        [BindProperty]
        public LoginModelprop _obj { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // ef core also supports linq query to fetch data from db
            var res = _db.Mytable.Any(x => x.Email == _obj.Email && x.Password == _obj.Password);//T or F
            if (res == true)
            {
                return RedirectToPage("Homepage");
            }
            else
            {
                TempData["errormsg"] = "Invalid email or password";
                return Page();
            }

        }
    }
}
