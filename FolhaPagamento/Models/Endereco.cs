﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Endereco
    {
        public int EnderecoID { get; set; }
        public String Rua { get; set; }
        public int Numero { get; set; }
        public int Cep { get; set; }
        public String Complemento { get; set; }

        
    }
}
