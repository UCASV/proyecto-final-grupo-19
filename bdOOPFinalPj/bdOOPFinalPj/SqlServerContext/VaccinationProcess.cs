using System;
using System.Collections.Generic;

#nullable disable

namespace bdOOPFinalPj.SqlServerContext
{
    public partial class VaccinationProcess
    {
        public VaccinationProcess()
        {
            Citizens = new HashSet<Citizen>();
            Effects = new HashSet<Effect>();
        }

        public int Id { get; set; }
        public DateTime? DateHourVaccination { get; set; }
        public DateTime? DateHourStart { get; set; }
        public DateTime? DateHourVaccinated { get; set; }
        public int? NumberMinutes { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
        public virtual ICollection<Effect> Effects { get; set; }
    }
}
