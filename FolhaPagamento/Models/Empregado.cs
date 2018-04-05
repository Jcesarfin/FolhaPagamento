using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Empregado
    {
        public int EmpregadoID { get; set; }
        public String Nome { get; set; }
        public String Identidade { get; set; }
        public String CPF { get; set; }
        public String Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataAdmissão { get; set; }
        public DateTime DataDemissão { get; set; }

        public int EnderecoID { get; set; }
        public Endereco _Endereco { get; set; }

        public int DepartamentoID { get; set; }
        public Departamento _Departamento { get; set; }

        public int CargoID { get; set; }
        public Cargo _Cargo { get; set; }

        public int SalarioID { get; set; }
        public Salario _Salario { get; set; }

    }
}
