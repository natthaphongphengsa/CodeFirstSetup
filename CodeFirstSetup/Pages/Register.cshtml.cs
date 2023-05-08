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
    public class RegisterModel : PageModel
    {
        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(12)]
        [Required]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 10)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        [MaxLength(12)]
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public int Contry { get; set; }

        [Required]
        public string Usertype { get; set; }

        public List<SelectListItem> usertypes { get; set; }
        public List<SelectListItem> contries { get; set; }

        public readonly ApplicationDbContext dbContext;

        public RegisterModel(ApplicationDbContext _dbcontext)
        {
            dbContext = _dbcontext;
        }

        public void OnGet()
        {
            contries = dbContext.contries.Select(c => new SelectListItem()
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();

            usertypes = Enum.GetValues(typeof(UserType)).Cast<UserType>().Select(u => new SelectListItem(u.ToString(), u.ToString())).ToList();
        }
        public IActionResult OnPost()
        {
            OnGet();
            if (ModelState.IsValid)
            {
                if (!dbContext.users.Any(u => u.Email == Email))
                {

                    var adduser = new UserRegistration();
                    adduser.Firstname = Firstname;
                    adduser.Lastname = Lastname;
                    adduser.Email = Email;
                    adduser.Password = Password;
                    adduser.ConfirmPassword = ConfirmPassword;
                    adduser.Contry = dbContext.contries.First(c => c.Id == Contry);
                    adduser.Usertype = Enum.Parse<UserType>(Usertype);
                    dbContext.users.Add(adduser);
                    dbContext.SaveChanges();
                }
                return RedirectToPage("/RegistrationConfirm", new { Firstname = Firstname });
            }
            return Page();
        }
    }
}
