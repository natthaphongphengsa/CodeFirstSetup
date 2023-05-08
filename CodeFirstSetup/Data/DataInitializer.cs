using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeFirstSetup.Data
{
    public class DataInitializer
    {
        public static void SeedData(ApplicationDbContext dbContext)
        {
            dbContext.Database.Migrate();
            SeedManufacturers(dbContext);
            SeedCar(dbContext);
            SeedTruck(dbContext);
            SeedFixManufatures(dbContext);
            SeedContries(dbContext);
            SeedEducations(dbContext);
            SeedKurs(dbContext);
        }
        public static void SeedKurs(ApplicationDbContext dbContext)
        {
            if (!dbContext.kurs.Any(c => c.Name == "Webbapplikationer och mobil utveckling"))
            {
                dbContext.kurs.Add(new Kurs()
                {
                    Name = "Webbapplikationer och mobil utveckling",
                    Description = "På denna kurs kommer ni få kunskapen för att bygga webbapplikationer.  Webbapplikationer innebär en viss arkitektur (händelsebaserad programmering)  och struktur (MVC, var och hur olika filer - css:er, html, js etc - används )",
                    Startday = new DateTime().AddDays(12).AddMonths(9).AddYears(2021),
                    LectureDay = DayOfWeek.Wednesday,
                    Created = DateTime.Now,
                    LastModeified = DateTime.Now
                });
            }
            dbContext.SaveChanges();
        }
        public static void SeedEducations(ApplicationDbContext dbContext)
        {
            List<Education> educations = new List<Education>();
            educations.Add(new Education() { Namn = "Yrkehögskolan Utbildning" });
            educations.Add(new Education() { Namn = "Gymnasial Utbildning" });
            educations.Add(new Education() { Namn = "Högskolan Utbildning" });

            foreach (Education education in educations)
            {
                if (!dbContext.educations.Any(e => e.Namn == education.Namn))
                {
                    dbContext.educations.Add(new Education()
                    {
                        Namn = education.Namn
                    });
                }
            }
            dbContext.SaveChanges();
        }
        public static void SeedCar(ApplicationDbContext dbContext)
        {
            var Toyota = dbContext.manufacturers.FirstOrDefault(t => t.name == "Toyota");
            var Nissan = dbContext.manufacturers.FirstOrDefault(t => t.name == "Nissan");
            var Honda = dbContext.manufacturers.FirstOrDefault(t => t.name == "Honda");

            if (!dbContext.car.Any(c => c.RegNumber == "ABT654"))
            {
                dbContext.car.Add(new Car()
                {
                    Manufacturer = Toyota,
                    Model = "Fortuner",
                    Year = 2019,
                    RegNumber = "ABT654",
                    HasRadio = true,
                    Price = 346296,
                });
            }
            if (!dbContext.car.Any(c => c.RegNumber == "ABG754"))
            {
                dbContext.car.Add(new Car()
                {
                    Manufacturer = Honda,
                    Model = "Civiq",
                    Year = 2020,
                    RegNumber = "ABG754",
                    HasRadio = false,
                    Price = 146296,
                });
            }
            if (!dbContext.car.Any(c => c.RegNumber == "CAD417"))
            {
                dbContext.car.Add(new Car()
                {
                    Manufacturer = Nissan,
                    Model = "GT",
                    Year = 2018,
                    RegNumber = "CAD417",
                    HasRadio = false,
                    Price = 248276,
                });
            }
        }
        public static void SeedTruck(ApplicationDbContext dbContext)
        {
            var Scanidivia = dbContext.manufacturers.First(s => s.name == "Scanidivia");
            var Renualt = dbContext.manufacturers.First(r => r.name == "Renualt");
            var Volvo = dbContext.manufacturers.First(v => v.name == "Volvo");

            if (!dbContext.truck.Any(t => t.RegNumber == "BRD352"))
            {
                dbContext.truck.Add(new Truck()
                {
                    Manufacture = Scanidivia,
                    LoadVolumeKvm = 60,
                    RegNumber = "BRD352",
                });
            }
            if (!dbContext.truck.Any(t => t.RegNumber == "KDS372"))
            {
                dbContext.truck.Add(new Truck()
                {
                    Manufacture = Renualt,
                    LoadVolumeKvm = 20,
                    RegNumber = "KDS372",
                });
            }
            if (!dbContext.truck.Any(t => t.RegNumber == "SDA254"))
            {
                dbContext.truck.Add(new Truck()
                {
                    Manufacture = Volvo,
                    LoadVolumeKvm = 20,
                    RegNumber = "SDA254",
                });
            }
            dbContext.SaveChanges();
        }
        public static void SeedManufacturers(ApplicationDbContext dbContext)
        {
            if (!dbContext.manufacturers.Any(m => m.name == "Volvo"))
            {
                dbContext.manufacturers.Add(new Manufacturer()
                {
                    name = "Volvo"
                });
            }
            if (!dbContext.manufacturers.Any(m => m.name == "Scanidivia"))
            {
                dbContext.manufacturers.Add(new Manufacturer()
                {
                    name = "Scanidivia"
                });
            }
            if (!dbContext.manufacturers.Any(m => m.name == "Renualt"))
            {
                dbContext.manufacturers.Add(new Manufacturer()
                {
                    name = "Renualt"
                });
            }
            if (!dbContext.manufacturers.Any(m => m.name == "Toyota"))
            {
                dbContext.manufacturers.Add(new Manufacturer()
                {
                    name = "Toyota"
                });
            }
            if (!dbContext.manufacturers.Any(m => m.name == "Honda"))
            {
                dbContext.manufacturers.Add(new Manufacturer()
                {
                    name = "Honda"
                });
            }
            if (!dbContext.manufacturers.Any(m => m.name == "Nissan"))
            {
                dbContext.manufacturers.Add(new Manufacturer()
                {
                    name = "Nissan"
                });
            }
            dbContext.SaveChanges();
        }
        public static void SeedFixManufatures(ApplicationDbContext dbContext)
        {
            var Toyota = dbContext.manufacturers.First(t => t.name == "Toyota");
            var Honda = dbContext.manufacturers.First(h => h.name == "Honda");
            var Nissan = dbContext.manufacturers.First(n => n.name == "Nissan");

            dbContext.car.First(T => T.RegNumber == "ABT654").Manufacturer = Toyota;
            dbContext.car.First(H => H.RegNumber == "ABG754").Manufacturer = Honda;
            dbContext.car.First(N => N.RegNumber == "CAD417").Manufacturer = Nissan;

            var Scanidivia = dbContext.manufacturers.First(t => t.name == "Scanidivia");
            var Volvo = dbContext.manufacturers.First(t => t.name == "Volvo");
            var Renualt = dbContext.manufacturers.First(t => t.name == "Renualt");

            dbContext.truck.First(S => S.RegNumber == "BRD352").Manufacture = Scanidivia;
            dbContext.truck.First(V => V.RegNumber == "SDA254").Manufacture = Volvo;
            dbContext.truck.First(R => R.RegNumber == "KDS372").Manufacture = Renualt;

            dbContext.SaveChanges();
        }
        public static void SeedContries(ApplicationDbContext dbContext)
        {
            List<Contries> contries = new List<Contries>();
            contries.Add(new Contries() { Name = "Sweden" });
            contries.Add(new Contries() { Name = "Norway" });
            contries.Add(new Contries() { Name = "Denmark" });

            foreach (Contries contry in contries)
            {
                if (!dbContext.contries.Any(c => c.Name == contry.Name))
                {
                    dbContext.contries.Add(new Contries()
                    {
                        Name = contry.Name
                    });
                }
            }
            dbContext.SaveChanges();

        }
    }
}
