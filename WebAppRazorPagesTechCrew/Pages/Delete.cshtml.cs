using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesTechCrew.Models;

namespace WebAppRazorPagesTechCrew.Pages
{
    public class DeleteModel : PageModel
    {
        public AppDb _db;
        public DeleteModel()
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

        public IActionResult OnPost(int id) {
            var find = _db.Mytable.Find(id);
            if (find!=null)
            {
                _db.Mytable.Remove(find);
                _db.SaveChanges();
                return RedirectToPage("userslist");
            }
            return Page();
        }
    }
}
