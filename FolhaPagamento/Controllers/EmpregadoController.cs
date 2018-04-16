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
            
            ContextoSingleton.Instancia.Empregados.Add(empregado);
            ContextoSingleton.Instancia.SaveChanges();      //  EXCEPTIONNNNNNNNNNNXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

            
        }

        // SELECT *

        public static List<Empregado> ListarEmpregados()
        {
            return ContextoSingleton.Instancia.Empregados.ToList();
        }


        // SELECT BY ID

        public static Empregado PesquisarPorID(int id)
        {
           
            return ContextoSingleton.Instancia.Empregados.Find(id);

        }

        public Empregado PesquisarPorNome(string nome)
        {
            var c = from x in ContextoSingleton.Instancia.Empregados
                    where x.Nome.ToLower().Contains(nome.Trim().ToLower())
                    select x;

            if (c != null)
                return c.FirstOrDefault();
            else
                return null;
        }


        // EDIT

        public static void EditarEmpregado(int id, Empregado novoEmpregado, Departamento novoDepartamento, Cargo novoCargo)
        {
            Empregado empregadoEditar = PesquisarPorID(id);

            if (empregadoEditar != null)

            {
                empregadoEditar.Nome = novoEmpregado.Nome;
                empregadoEditar.Identidade = novoEmpregado.Identidade;
                empregadoEditar.CPF = novoEmpregado.CPF;
                //empregadoEditar.DataNascimento = novoEmpregado.DataNascimento;
                //empregadoEditar.DataAdmissão = novoEmpregado.DataAdmissão;
                //empregadoEditar.DataDemissão = novoEmpregado.DataDemissão;
                empregadoEditar.Departamento = novoDepartamento.NomeDepartamento;
                empregadoEditar.Cargo = novoCargo.NomeCargo;
                // VER TELA MANUTENÇÃO FALTAM MAIS ITENS


                ContextoSingleton.Instancia.Entry(empregadoEditar).State = System.Data.Entity.EntityState.Modified;

                ContextoSingleton.Instancia.SaveChanges();



            }
        }

        // DELETE

        public static void ExcluirEmpregado(int id)
        {
            
            Empregado e = ContextoSingleton.Instancia.Empregados.Find(id);
            ContextoSingleton.Instancia.Entry(e).State = System.Data.Entity.EntityState.Deleted;

            ContextoSingleton.Instancia.SaveChanges();

        }


    }
}
