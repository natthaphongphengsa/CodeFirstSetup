using System.ComponentModel.DataAnnotations;

namespace CodeFirstSetup.Data
{
    public class Truck
    {
        public int Id { get; set; }

        public Manufacturer Manufacture { get; set; }

        [MaxLength(100)]
        public int LoadVolumeKvm { get; set; }

        [MaxLength(6)]
        public string RegNumber { get; set; }
    }
}
