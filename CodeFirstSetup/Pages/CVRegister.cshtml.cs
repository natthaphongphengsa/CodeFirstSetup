using CodeFirstSetup.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CodeFirstSetup.Pages
{
    [BindProperties]
    public class CVRegisterModel : PageModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Only number is allow")]
        [MaxLength(10)]
        public string Mobile { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [MaxLength(5)]
        public string ZipCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public bool DriverLicence { get; set; }
        [Required]
        public bool HaveCar { get; set; }
        [Required]
        public string SelectedWorkLocation { get; set; }
        [Required]
        public List<int> SelectedEducationId { get; set; } = new List<int>();

        public List<string> WorkLocations { get; set; }
        public List<SelectListItem> Educations { get; set; }

        private readonly ApplicationDbContext _dbcontext;

        public CVRegisterModel(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public void OnGet()
        {
            WorkLocations = Enum.GetValues(typeof(WorkLocations)).Cast<WorkLocations>()
                .Select(u => u.ToString()).ToList();
            Educations = _dbcontext.educations.Select(e => new SelectListItem
            {
                Text = e.Namn,
                Value = e.Id.ToString()
            }).ToList();
        }
        public IActionResult OnPost()
        {
            OnGet();
            if (ModelState.IsValid)
            {
                var cv = new CV();
                cv.Name = Name;
                cv.Address = Address;
                cv.City = City;
                cv.DriverLicence = DriverLicence;
                cv.ZipCode = ZipCode;
                cv.Mobile = Mobile.ToString();
                cv.HaveCar = HaveCar;
                cv.WorkLocaltion = Enum.Parse<WorkLocations>(SelectedWorkLocation);
                cv.Educations = _dbcontext.educations.Where(e => SelectedEducationId.Contains(e.Id)).ToList();
                cv.Email = Email;
                _dbcontext.cv.Add(cv);
                _dbcontext.SaveChanges();
                return RedirectToPage("/RegistrationConfirm", new { Firstname = Name });
            }
            return Page();
        }
    }
}
