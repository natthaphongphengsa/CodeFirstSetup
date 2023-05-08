using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstSetup.Pages.Datum
{
    [BindProperties]
    public class DatumpageModel : PageModel
    {
        [Required]
        [Range(1, 31, ErrorMessage = "Dag måste vara mellan {1} - {2}")]
        public int Date { get; set; }
        [Required]
        [Range(1, 12, ErrorMessage = "Månad måste vara mellan {1} - {2}")]
        public int Month { get; set; }
        [Required]
        [Range(1900, 2040, ErrorMessage = "Årtalet måste vara mellan {1} - {2}")]
        public int Year { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {

            }
            return Page();
        }
    }
}
