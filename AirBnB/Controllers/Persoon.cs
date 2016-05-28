using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AirBnB.Controllers
{
    public class Persoon
    {
        public int Id { get; }
        public string FirstName { get; set; }
        [Required]
        [DefaultValue("Onbekend")]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string ZipCode { get; set; }
        [Required]
        public DateTime CreationDateTime { get; }

        Persoon()
        {
            CreationDateTime = DateTime.Today;
        }

        public override string ToString()
        {  
            return string.Join(" ", FirstName, MiddleName, LastName);
        }
    }
}