﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_20_2016.Model
{
    public class DodatneUsluge
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Cena { get; set; }
        public bool Obrisan { get; set; }
    }
}
