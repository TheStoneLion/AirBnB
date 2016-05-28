using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBnB.Controllers
{
    public class Verhuurder
    {
        public int Id { get; }
        public Persoon Persoon { get; set; }
    }
}