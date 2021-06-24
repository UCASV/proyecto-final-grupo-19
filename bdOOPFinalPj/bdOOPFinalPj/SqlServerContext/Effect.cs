using System;
using System.Collections.Generic;

#nullable disable

namespace bdOOPFinalPj.SqlServerContext
{
    public partial class Effect
    {
        public int Id { get; set; }
        public string SideEffects { get; set; }
        public int? IdProcess { get; set; }

        public virtual VaccinationProcess IdProcessNavigation { get; set; }
    }
}
