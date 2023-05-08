using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstSetup.Data
{
    public class CV
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [MaxLength(10)]
        public string Mobile { get; set; }

        [Required]
        public string Address { get; set; }

        [MaxLength(6)]
        public string ZipCode { get; set; }

        [Required]
        public string City { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public List<Education> Educations { get; set; }

        [Required]
        public WorkLocations WorkLocaltion { get; set; }

        [Required]
        public bool DriverLicence { get; set; }

        [Required]
        public bool HaveCar { get; set; }
    }
}