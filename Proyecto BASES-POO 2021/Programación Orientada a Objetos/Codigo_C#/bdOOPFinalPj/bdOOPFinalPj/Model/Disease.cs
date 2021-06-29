using System;
using System.Collections.Generic;

#nullable disable

namespace bdOOPFinalPj.SqlServerContext
{
    public partial class Disease
    {
        public int Id { get; set; }
        public string Diseases { get; set; }
        public string IdCitizen { get; set; }

        public virtual Citizen IdCitizenNavigation { get; set; }
    }
}
