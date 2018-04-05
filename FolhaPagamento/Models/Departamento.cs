using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Departamento
    {
        public int DepartamentoID { get; set; }
        public String NomeDepartamento { get; set; }
        public String LocalDepartamento { get; set; }

        public int EmpregadoID { get; set; }
        public Empregado _Empregado { get; set; }
    }
}
