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
        public decimal VlrHoraNormal { get; set; }
        public decimal VlrHoraExtra { get; set; }
        public decimal VlrInss { get; set; }
        public decimal VlrIR { get; set; }
        public decimal SalarioBruto { get; set; }
        public decimal SalarioLiquido { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
            
        public int EmpregadoID { get; set; }
        public virtual Empregado _Empregado { get; set; }

        //public int CargoID { get; set; }
        //public Cargo _Cargo { get; set; }

        //public int DepartamentoID { get; set; }
        //public Departamento _Departamento { get; set; }

    }
}
