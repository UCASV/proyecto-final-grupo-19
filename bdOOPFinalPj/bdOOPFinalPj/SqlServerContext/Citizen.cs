using System;
using System.Collections.Generic;

#nullable disable

namespace bdOOPFinalPj.SqlServerContext
{
    public partial class Citizen
    {
        public Citizen()
        {
            Diseases = new HashSet<Disease>();
        }

        public string Dui { get; set; }
        public string Addres { get; set; }
        public string NameCitizen { get; set; }
        public int? Age { get; set; }
        public string Mail { get; set; }
        public int? Phone { get; set; }
        public int? IdCabin { get; set; }
        public int? IdVaccinationP { get; set; }
        public int? IdIdentifier { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Identifier IdIdentifierNavigation { get; set; }
        public virtual VaccinationProcess IdVaccinationPNavigation { get; set; }
        public virtual ICollection<Disease> Diseases { get; set; }
    }
}
