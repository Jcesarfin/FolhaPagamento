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
            ContextoSingleton.Instancia.SaveChanges();      

            
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

        // SELECT BY CPF - UTILIZADA NA FOLHA E NA MANUTENÇÃO EMPREGADO

        public Empregado PesquisarPorCpf(string cpf)
        {
            var c = from x in ContextoSingleton.Instancia.Empregados
                    where x.CPF.ToLower().Contains(cpf.Trim().ToLower())
                    select x;

            if (c != null)
                return c.FirstOrDefault();
            else
                return null;
        }


        // EDIT  -> UTILIZADO

        public static void EditarEmpregado(int id, Empregado novoEmpregado, Endereco novoEndereco)
        {
            Empregado empregadoEditar = PesquisarPorID(id);

            if (empregadoEditar != null)

            {
                empregadoEditar.Nome = novoEmpregado.Nome;
                empregadoEditar.Identidade = novoEmpregado.Identidade;
                empregadoEditar.CPF = novoEmpregado.CPF;
                empregadoEditar.DataNascimento = novoEmpregado.DataNascimento;
                empregadoEditar.DataAdmissão = novoEmpregado.DataAdmissão;
                empregadoEditar.DataDemissão = novoEmpregado.DataDemissão;
                empregadoEditar.Departamento = novoEmpregado.Departamento;
                empregadoEditar.Cargo = novoEmpregado.Cargo;

                empregadoEditar._Endereco.Rua = novoEndereco.Rua;
                empregadoEditar._Endereco.Numero = novoEndereco.Numero;
                empregadoEditar._Endereco.Cep = novoEndereco.Cep;
                empregadoEditar._Endereco.Complemento = novoEndereco.Complemento;


                ContextoSingleton.Instancia.Entry(empregadoEditar).State = System.Data.Entity.EntityState.Modified;

                ContextoSingleton.Instancia.SaveChanges();

                
            }
        }

        // DELETE -> UTILIZADO

        public static void ExcluirEmpregado(int EmpregadoID)
        {
            
            Empregado e = ContextoSingleton.Instancia.Empregados.Find(EmpregadoID);
            ContextoSingleton.Instancia.Entry(e).State = System.Data.Entity.EntityState.Deleted;

            ContextoSingleton.Instancia.SaveChanges();

        }


    }
}
