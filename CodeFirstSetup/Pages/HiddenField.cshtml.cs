using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeFirstSetup.Pages
{
    public class HiddenFieldModel : PageModel
    {
        [HiddenInput]
        [BindProperty]
        public int Count { get; set; }

        public void OnGet()
        {
        }
        public void Onpost()
        {
            Count++;
        }
    }
}
