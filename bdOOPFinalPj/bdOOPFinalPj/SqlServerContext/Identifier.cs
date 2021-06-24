using System;
using System.Collections.Generic;

#nullable disable

namespace bdOOPFinalPj.SqlServerContext
{
    public partial class Identifier
    {
        public Identifier()
        {
            Citizens = new HashSet<Citizen>();
        }

        public int Id { get; set; }
        public string Identifier1 { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}
