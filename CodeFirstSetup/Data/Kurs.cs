using System;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstSetup.Data
{
    public class Kurs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [MaxLength(512)]
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModeified { get; set; }
        public DateTime Startday { get; set; }
        public DayOfWeek LectureDay { get; set; }
    }
}
