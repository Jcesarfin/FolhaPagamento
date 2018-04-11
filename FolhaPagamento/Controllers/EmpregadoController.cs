using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class EmpregadoController
    {

        // INSERT

        public static void SalvarEmpregado(Empregado empregado)
        {
            MeuContexto bancoDados = new MeuContexto();

            bancoDados.Empregados.Add(empregado);
            bancoDados.SaveChanges();
        }

        // SELECT *

        public static List<Empregado> ListarEmpregados()
        {
            MeuContexto bancoDados = new MeuContexto();
            return bancoDados.Empregados.ToList();
        }

        // SELECT BY ID

        public static Empregado PesquisarPorID(int id)
        {
            MeuContexto bancoDados = new MeuContexto();
            return bancoDados.Empregados.Find(id);
        }

        // EDIT

        public static void EditarEmpregado(int id, Empregado novoEmpregado)
        {
            MeuContexto bancoDados = new MeuContexto();
            Empregado empregadoAtual = bancoDados.Empregados.Find(id);

            empregadoAtual.Nome = novoEmpregado.Nome;
            empregadoAtual.Identidade = novoEmpregado.Identidade;
            empregadoAtual.CPF = novoEmpregado.CPF;
            empregadoAtual.DataNascimento = novoEmpregado.DataNascimento;
            empregadoAtual.DataAdmissão = novoEmpregado.DataAdmissão;
            empregadoAtual.DataDemissão = novoEmpregado.DataDemissão;
            empregadoAtual._Departamento.NomeDepartamento = novoEmpregado._Departamento.NomeDepartamento;
            empregadoAtual._Cargo.NomeCargo = novoEmpregado._Cargo.NomeCargo;
            // VER TELA MANUTENÇÃO FALTAM MAIS ITENS


            bancoDados.Entry(empregadoAtual).State = System.Data.Entity.EntityState.Modified;
            bancoDados.SaveChanges();

        }

        // DELETE

        public static void ExcluirEndereco(int id)
        {
            MeuContexto bancoDados = new MeuContexto();
            Empregado empregadoAtual = bancoDados.Empregados.Find(id);

            bancoDados.Entry(empregadoAtual).State = System.Data.Entity.EntityState.Deleted;
            bancoDados.SaveChanges();

        }


    }
}
