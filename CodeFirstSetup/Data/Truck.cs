using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstSetup.Data
{
    public class Truck
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Manufacturer { get; set; }
        
        [MaxLength(100)]
        public int LoadVolumeKvm { get; set; }

        [MaxLength(6)]
        public string RegNumber { get; set; }
    }
}
