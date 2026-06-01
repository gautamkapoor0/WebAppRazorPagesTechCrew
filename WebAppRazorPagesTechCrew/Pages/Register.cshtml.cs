using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesTechCrew.Models;

namespace WebAppRazorPagesTechCrew.Pages
{
    public class RegisterModel : PageModel
    {
        public AppDb _db;
        public RegisterModel()
        {
            _db = new AppDb();
        }

        [BindProperty]

        public RegisterModelProp _obj { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            _db.Mytable.Add(_obj);
            _db.SaveChanges();
            //UI --> _obj --> pagemodel--> ef core --> Db
        }
    }
}
