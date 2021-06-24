using System;
using System.Collections.Generic;

#nullable disable

namespace bdOOPFinalPj.SqlServerContext
{
    public partial class Managerxregistration
    {
        public int IdManager { get; set; }
        public int IdRecord { get; set; }

        public virtual Manager IdManagerNavigation { get; set; }
        public virtual Registration IdRecordNavigation { get; set; }
    }
}
