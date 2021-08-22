using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
