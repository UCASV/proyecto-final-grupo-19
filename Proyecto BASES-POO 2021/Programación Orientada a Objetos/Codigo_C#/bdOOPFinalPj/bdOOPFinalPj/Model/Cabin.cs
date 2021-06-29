using System;
using System.Collections.Generic;

#nullable disable

namespace bdOOPFinalPj.SqlServerContext
{
    public partial class Cabin
    {
        public Cabin()
        {
            Citizens = new HashSet<Citizen>();
            Registrations = new HashSet<Registration>();
        }

        public int Id { get; set; }
        public string Addres { get; set; }
        public int? Phone { get; set; }
        public string NameManager { get; set; }
        public string Mail { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
