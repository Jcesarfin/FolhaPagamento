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
        public float VlrHoraNormal { get; set; }
        public float VlrHoraExtra { get; set; }
        public float VlrInss { get; set; }
        public float VlrIR { get; set; }
        public float SalarioBruto { get; set; }
        public float SalarioLiquido { get; set; }
        public DateTime MesReferencia { get; set; }
        public int AnoReferencia { get; set; }


        public int EmpregadoID { get; set; }
        public Empregado _Empregado { get; set; }

        public int CargoID { get; set; }
        public Cargo _Cargo { get; set; }

        public int DepartamentoID { get; set; }
        public Departamento _Departamento { get; set; }

    }
}
