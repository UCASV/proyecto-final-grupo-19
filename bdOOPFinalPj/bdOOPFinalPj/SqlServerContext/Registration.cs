using System;
using System.Collections.Generic;

#nullable disable

namespace bdOOPFinalPj.SqlServerContext
{
    public partial class Registration
    {
        public Registration()
        {
            Managerxregistrations = new HashSet<Managerxregistration>();
        }

        public int Id { get; set; }
        public DateTime? DateHour { get; set; }
        public int? IdCabin { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual ICollection<Managerxregistration> Managerxregistrations { get; set; }
    }
}
