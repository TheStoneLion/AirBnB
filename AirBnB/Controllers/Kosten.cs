using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBnB.Controllers
{
    public class Kosten
    {
        public int Id { get; set; }
        public string Omschrijving { get; set; }
        public int MyProperty { get; set; }
        public double bedrag { get; set; }
        public KostenType KostenType { get; set; }
        public DateTime BeginDatum { get; set; }
        public DateTime EindDatum { get; set; }
    }
}