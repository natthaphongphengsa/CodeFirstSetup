using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeFirstSetup.Pages
{
    [BindProperties]
    public class MultiplyinputModel : PageModel
    {        
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        
        [Required]
        [MaxLength(512)]
        public string Text { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return RedirectToPage("/ThanksYou");
            }
            return Page();
        }
    }
}
