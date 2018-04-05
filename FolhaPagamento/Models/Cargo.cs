﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cargo
    {
        public int CargoID { get; set; }
        public String NomeCargo { get; set; }
        public float ValorHora { get; set; }

        public int EmpregadoID { get; set; }
        public Empregado _Empregado { get; set; }
    }
}
