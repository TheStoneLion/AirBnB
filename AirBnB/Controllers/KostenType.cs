using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBnB.Controllers
{
    [Flags]
    enum Interval
    {
        PerVerblijf,
        PerNacht,
        PerPersoon
    }
    public class KostenType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        // Toeristenbelasting en andere kosten die mogen worden afgetrokken
        // zoals schoonmaakkosten, energiekosten en waskosten
        public int KostenInterval { get; set; }
    }
}