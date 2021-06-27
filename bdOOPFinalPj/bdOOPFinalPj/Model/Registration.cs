using System;
using System.Collections.Generic;

#nullable disable

namespace bdOOPFinalPj.SqlServerContext
{
    public partial class Registration
    {
        public int Id { get; set; }
        public DateTime? DateHour { get; set; }
        public int? IdCabin { get; set; }
        public int? IdManager { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Manager IdManagerNavigation { get; set; }
    }
}
