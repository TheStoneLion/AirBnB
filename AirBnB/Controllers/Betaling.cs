using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirBnB.Controllers
{
    public class Betaling
    {
        public int Id { get; set; }
        public DateTime BetalingsDatum { get; set; }
        public Double Bedrag { get; set; }
        public Reservering Reservering { get; set; }
    }
}