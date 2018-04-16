using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Salario
    {
        public int SalarioID { get; set; }
        public int QtdeHoraNormal { get; set; }
        public int QtdeHoraExtra { get; set; }
        public double VlrHoraNormal { get; set; }
        public double VlrHoraExtra { get; set; }
        public double VlrInss { get; set; }
        public double VlrIR { get; set; }
        public double SalarioBruto { get; set; }
        public double SalarioLiquido { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
            

        public int CargoID { get; set; }
        public Cargo _Cargo { get; set; }

        public int DepartamentoID { get; set; }
        public Departamento _Departamento { get; set; }

    }
}
