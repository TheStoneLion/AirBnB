using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBnB.Controllers
{
    public class Gast
    {
        public int Id { get; set; }
        public Persoon Persoon { get; set; }
        public Reservering Reservering { get; set; }
    }
}