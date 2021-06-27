using System;
using System.Collections.Generic;

#nullable disable

namespace bdOOPFinalPj.SqlServerContext
{
    public partial class TypeOfEmployee
    {
        public TypeOfEmployee()
        {
            Managers = new HashSet<Manager>();
        }

        public int Id { get; set; }
        public string TypeEmployed { get; set; }

        public virtual ICollection<Manager> Managers { get; set; }
    }
}
