﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_20_2016_GUI.Model
{

    [Serializable]
    public class DodatnaUsluga
    {
        public int id{ get; set; }
        public string naziv { get; set; }
        public bool obrisan{ get; set; }
        public double cena { get; set; }
    }
}
