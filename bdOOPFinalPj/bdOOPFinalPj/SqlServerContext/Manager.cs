using System;
using System.Collections.Generic;

#nullable disable

namespace bdOOPFinalPj.SqlServerContext
{
    public partial class Manager
    {
        public Manager()
        {
            Managerxregistrations = new HashSet<Managerxregistration>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordUser { get; set; }
        public string NameUser { get; set; }
        public string Mail { get; set; }
        public string Addres { get; set; }
        public int? IdTypeEmployed { get; set; }

        public virtual TypeOfEmployee IdTypeEmployedNavigation { get; set; }
        public virtual ICollection<Managerxregistration> Managerxregistrations { get; set; }
    }
}
