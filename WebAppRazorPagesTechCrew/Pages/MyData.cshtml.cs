using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesTechCrew.Models;

namespace WebAppRazorPagesTechCrew.Pages
{
    public class MyDataModel : PageModel
    {
        //model prop from page model --> Reduse code complexity

        [BindProperty]
        public UserData _mydata { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {

            // here data to db
            TempData["res"] = _mydata.UserName;
        }
    }
}
