using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeFirstSetup.Pages
{
    public class ThanksYouModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Thansk you for your questions....";
        }
    }
}
