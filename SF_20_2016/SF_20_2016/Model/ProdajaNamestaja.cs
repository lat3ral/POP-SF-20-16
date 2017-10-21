﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_20_2016.Model
{
public  class ProdajaNamestaja
    {
        public int Id { get; set; }
        public List<Namestaj> NamestajZaProdaju { get; set; }
        public string BrojRacuna { get; set; }
        public string Kupac { get; set; }
        public List<DodatneUsluge> DodatneUsluge { get; set; }
        public double PDV { get; set; }
        public double UkupnaCena { get; set; }
    }
}
