using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VertragsLibrary;

namespace WebAPI.Controllers
{
    public class VertragController : ApiController
    {
        Vertrag v1 = new Vertrag();

        // GET: api/Vertrag
        public Vertrag Get()
        {
            v1.Versicherungsnehmer.Vorname = "Franz";
            v1.Versicherungsnehmer.Nachname = "Buchner";

            //Versicherte Person hinzufügen
            VersichertePerson p1 = new VersichertePerson();
            p1.Vorname = "Versicherte Person Nr1";
            v1.VersichertePersonen.Add(p1);

            return v1;
        }            
    }
}
