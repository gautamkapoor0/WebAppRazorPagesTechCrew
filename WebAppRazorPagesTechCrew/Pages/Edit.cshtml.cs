using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesTechCrew.Models;

namespace WebAppRazorPagesTechCrew.Pages
{
    public class EditModel : PageModel
    {
        public AppDb _db;
        public EditModel()
        {
            _db = new AppDb();
        }

        [BindProperty]
        public RegisterModelProp _obj { get; set; }
        public void OnGet(int id)
        {
            // get the data from db based on id
            _obj = (from s in _db.Mytable where s.ID == id select s).FirstOrDefault();
        }

        public IActionResult OnPost() {
            _db.Mytable.Update(_obj);
            _db.SaveChanges();
            return RedirectToPage("userslist");
        }
    }
}
