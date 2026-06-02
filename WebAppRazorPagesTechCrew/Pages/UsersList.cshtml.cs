using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesTechCrew.Models;

namespace WebAppRazorPagesTechCrew.Pages
{
    public class UsersListModel : PageModel
    {
        public AppDb _db;
        public UsersListModel()
        {
            _db = new AppDb();
        }
        [BindProperty]
        public List<RegisterModelProp> userlist { get; set; }

        public void OnGet()
        {
            //  var res = _db.Mytable.ToList();
            userlist = (from s in _db.Mytable
                        select s).ToList();
        }
    }
}
