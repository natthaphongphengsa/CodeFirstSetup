using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSetup.Data
{
    public class DataInitializer
    {
        public static void SeedData(ApplicationDbContext dbContext)
        {
            dbContext.Database.Migrate();
            SeedCar(dbContext);
            SeedTruck(dbContext);
        }
        public static void SeedCar(ApplicationDbContext dbContext)
        {            
            if (!dbContext.car.Any(c => c.RegNumber == "ABT654"))
            {
                dbContext.car.Add(new Car()
                {
                    Manufacturer = "Toyota",
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
                    Manufacturer = "Honda",
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
                    Manufacturer = "Nissan",
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
            if (!dbContext.truck.Any(t => t.RegNumber == "BRD352"))
            {
                dbContext.truck.Add(new Truck()
                {
                    Manufacture = "Scanidivia",
                    LoadVolumeKvm = 60,
                    RegNumber = "BRD352",
                });
            }
            if (!dbContext.truck.Any(t => t.RegNumber == "KDS372"))
            {
                dbContext.truck.Add(new Truck()
                {
                    Manufacture = "Renualt",
                    LoadVolumeKvm = 20,
                    RegNumber = "KDS372",
                });
            }
            if (!dbContext.truck.Any(t => t.RegNumber == "SDA254"))
            {
                dbContext.truck.Add(new Truck()
                {
                    Manufacture = "Volvo",
                    LoadVolumeKvm = 20,
                    RegNumber = "SDA254",
                });
            }
            dbContext.SaveChanges();
        }
    }
}
