using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBnB.Controllers
{
    public class Reservering
    {
        public int Id { get; set; }
        public string AirBnbCode { get; set; }
        public DateTime IncheckDatum { get; set; }
        public int AantalNachten { get; set; }
        public int AantalPersonen { get; set; }
        public double TotalePrijs { get; set; }
    }
}