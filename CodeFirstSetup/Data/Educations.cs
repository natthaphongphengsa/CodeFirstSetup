using System.Collections.Generic;

namespace CodeFirstSetup.Data
{
    public class Education
    {
        public int Id { get; set; }

        public string Namn { get; set; }

        public List<CV> cvs { get; set; }
    }
}
