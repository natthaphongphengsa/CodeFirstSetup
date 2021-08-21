using CodeFirstSetup.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstSetup.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public readonly ApplicationDbContext _dbContext;
        public List<Car> car { get; set; }
        public List<Truck> truck { get; set; }

        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string RegNumber { get; set; }
        public decimal Price { get; set; }
        public bool HasRadio { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public void OnGet()
        {
            car = _dbContext.car.ToList();
            truck = _dbContext.truck.ToList();
        }
    }
}
