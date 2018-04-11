using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class DepartamentoController
    {

        // INSERT

        public static void SalvarDepartamento (Departamento departamento)
        {
            MeuContexto bancoDados = new MeuContexto();

            bancoDados.Departamentos.Add(departamento);
            bancoDados.SaveChanges();
            
        }

        // SELECT *

        public static List<Departamento> ListarDepartamentos()
        {
            MeuContexto bancoDados = new MeuContexto();
            return bancoDados.Departamentos.ToList();
        }

        // SELECT BY ID

        public static Departamento PesquisarPorID (int id)
        {
            MeuContexto bancoDados = new MeuContexto();
            return bancoDados.Departamentos.Find(id);
        }

        // EDIT

        public static void EditarDepartamento (int id, Departamento novoDepartamento)
        {
            MeuContexto bancoDados = new MeuContexto();
            Departamento departamentoAtual = bancoDados.Departamentos.Find(id);

            departamentoAtual.NomeDepartamento = novoDepartamento.NomeDepartamento;
            departamentoAtual.LocalDepartamento = novoDepartamento.LocalDepartamento;

            bancoDados.Entry(departamentoAtual).State = System.Data.Entity.EntityState.Modified;
            bancoDados.SaveChanges();

        }

        // DELETE

        public static void ExcluirDepartamento (int id)
        {
            MeuContexto bancoDados = new MeuContexto();
            Departamento departamentoAtual = bancoDados.Departamentos.Find(id);

            bancoDados.Entry(departamentoAtual).State = System.Data.Entity.EntityState.Deleted;
            bancoDados.SaveChanges();

        }
        
    }
}
