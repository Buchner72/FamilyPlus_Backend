using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using static WebAPI.Models.Person;

namespace WebAPI.Controllers
{
    public class PersonenController : ApiController  //http://localhost:57375/api/personen  http://localhost:57375/swagger
    {
        //Testnachricht

        IList<PersonN> personen = new List<PersonN>() {
                new PersonN(){ Id=1, Vorname="Franz", Nachname="MyWebAPI",IsKind=false,PraemieFP="1,99", AdresseId=10 },
                new PersonN(){ Id=2, Vorname="Felix", Nachname="Buchner",IsKind=false ,PraemieFP="1,99", AdresseId=10},
                new PersonN(){ Id=3, Vorname="Heinz", Nachname="Moser",IsKind=true,PraemieFP="1,99",  AdresseId=10},
                new PersonN(){ Id=3, Vorname="Johann", Nachname="Scherz",IsKind=true,PraemieFP="1,99", AdresseId=10},
                new PersonN(){ Id=4, Vorname="Ludwig", Nachname="Pirker", IsKind=true,PraemieFP="1,99", AdresseId=10}
            };

        [HttpGet]
        //Besser wäre angeblich Puplic List<PersonN>
        public IEnumerable<PersonN> Get()
        {
            return personen;
        }


        public PersonN Get(int id)
        #region "Diese Version würde ein Http Request mit Status  400 liefern"
        //  public IHttpActionResult Get(int id)
        //foreach (var p in personen)
        //{
        //    if (id==p.Id)
        //    {
        //        return Ok(p);
        //    }                   
        //}
        //return BadRequest();
        #endregion
        {

            return personen.Where(x => x.Id == id).FirstOrDefault();

        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] PersonN person)
        {
            int Id = personen.Count + 1;
            person.Id = Id;
            personen.Add(person);

            return Ok(person);
        }

        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] PersonN person)
        {
            return Ok(person);
        }

        //Direckt aufrufbare Funktionen
        [Route("api/Personen/GetFirstName")]   //Aufruf: GET - http://localhost:49608/api/Personen/GetFirstName 
        public List<string> GetFirstName()
        {
            List<string> output = new List<string>();
            foreach (var p in personen)
            {
                output.Add(p.Vorname);
            }
            return output;
        }

        [Route("api/Personen/ClacFP")]   //Aufruf: GET - http://localhost:49608/api/Personen/ClacFP
        public IEnumerable<PersonN> GetPraemieFP()
        {
            foreach (var p in personen)
            {
                if (p.IsKind)
                {
                    p.PraemieFP = "3,90";
                }
                else
                {
                    p.PraemieFP = "5,70";
                }
            }
            return personen;
        }
    }
}
