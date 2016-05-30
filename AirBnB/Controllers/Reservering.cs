using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AirBnB.Controllers
{
    public class Reservering
    {
        public int Id { get; set; }
        [Required]
        public string AirBnbCode { get; set; }
        [Required]
        public DateTime IncheckDatum { get; set; }
        [Required]
        public int AantalNachten { get; set; }
        [Required]
        public int AantalPersonen { get; set; }
        [Required]
        public double TotalePrijs { get; set; }
    }
}