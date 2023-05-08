using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeFirstSetup.Pages
{
    public class RegistrationConfirmModel : PageModel
    {
        public string Firstname { get; set; }
        public void OnGet(string firstname)
        {
            Firstname = firstname;
        }
    }
}
