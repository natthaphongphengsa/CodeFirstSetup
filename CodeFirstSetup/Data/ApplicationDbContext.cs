using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstSetup.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Car> car { get; set; }
        public DbSet<Truck> truck { get; set; }
        public DbSet<Manufacturer> manufacturers { get; set; }
        public DbSet<UserRegistration> users { get; set; }
        public DbSet<Contries> contries { get; set; }
        public DbSet<CV> cv { get; set; }
        public DbSet<Education> educations { get; set; }
        public DbSet<Kurs> kurs { get; set; }
    }
}
