using CodeFirstSetup.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace CodeFirstSetup.Pages.kurs
{
    public class KursListModel : PageModel
    {
        public List<Data.Kurs> kurs { get; set; } = new List<Data.Kurs>();
        public readonly ApplicationDbContext _dbContext;

        public KursListModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void OnGet()
        {
            kurs = _dbContext.kurs.ToList();
        }
    }
}
