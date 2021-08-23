using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
