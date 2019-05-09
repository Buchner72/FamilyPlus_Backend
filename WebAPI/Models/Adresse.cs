using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static WebAPI.Models.Person;

namespace WebAPI.Models
{
    public class Adresse
    {
        public Adresse()
        {
            Personen = new HashSet<PersonN>();
        }

        public int Id { get; set; }
        public string Strasse { get; set; }
        public string Ort { get; set; }

        public virtual ICollection<PersonN> Personen { get; set; }
    }
}