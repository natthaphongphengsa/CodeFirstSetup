using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstSetup.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeFirstSetup.Pages.Kurs
{
    [BindProperties]
    public class EditModel : PageModel
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(512)]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime LastModeified { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Startday { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DayOfWeek LectureDay { get; set; }

        public readonly ApplicationDbContext _dbcontext;
        public EditModel(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public void OnGet(int id)
        {
            var kurs = _dbcontext.kurs.First(k => k.Id == id);
            Name = kurs.Name;
            Description = kurs.Description;
            Created = kurs.Created;
            LastModeified = kurs.LastModeified;
            Startday = kurs.Startday;
            LectureDay = kurs.LectureDay;

        }
        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
