using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VertragsLibrary;

namespace WebAPI.Controllers
{
    public class VTVPController : ApiController
    {

        List<Person> ListP = new List<Person>();

        // GET: api/VTVP
        public List<Person> GetVP()
        {
            Person p1 = new Person();
            p1.Anrede = EnumData.Anrede.Herr;
            p1.Titel = "Mag";
            p1.Vorname = "Robert";
            p1.Nachname = "Krallinger";
            p1.Geburtsdatum = "01.01.1980";
            p1.Alter = "39";  // In einer Funktion berechnen

            
            ListP.Add(p1);

            Person p2 = new Person();
            p2.Anrede = EnumData.Anrede.Frau;
            p2.Vorname = "Maria";
            p2.Nachname = "Krallinger";
            p2.Geburtsdatum = "23.05.1972";
            p2.Alter = "47";  // In einer Funktion berechnen
            ListP.Add(p2);

            return ListP;      
        }
    }
}
