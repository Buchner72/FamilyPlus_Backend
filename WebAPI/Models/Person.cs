﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Person
    {
        public class PersonN
        {
            public int Id { get; set; }
            public string Anrede { get; set; }
            public string Titel { get; set; }
            public string Vorname { get; set; }
            public string Nachname { get; set; }
            public string Geburtsdatum { get; set; }
            public int Alter { get; set; }
            public bool IsKind { get; set; }
            public string PraemieFP { get; set; }
            public int AdresseId { get; set; }
            public Adresse Adresse { get; set; }
        }
    }
}