using System.ComponentModel.DataAnnotations;

namespace WebAppRazorPagesTechCrew.Models
{
    public class RegisterModelProp
    {
        [Key]
        public int ID { get; set; }  // [key define ID as pk and auto increment]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
    }
}
