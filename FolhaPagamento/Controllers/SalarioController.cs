using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class SalarioController
    {
        // INSERT

        public static void SalvarSalario(Salario salario)
        {
            ContextoSingleton.Instancia.Salarios.Add(salario);
            ContextoSingleton.Instancia.SaveChanges();

        }

        // SELECT *

        public static List<Salario> ListarSalarios()
        {
           return ContextoSingleton.Instancia.Salarios.ToList();

        }

        // SELECT BY ID

        public static Salario PesquisarPorID(int id)
        {
            return ContextoSingleton.Instancia.Salarios.Find(id);
        }

        //public Salario PesquisarPorNome(string nome)
        //{
        //    var c = from x in ContextoSingleton.Instancia.Salarios
        //            where x.Nome.ToLower().Contains(nome.Trim().ToLower()) // ver relacionamento com empregado
      //              select x;

       //     if (c != null)
         //       return c.FirstOrDefault();
         //   else
          //      return null;
       // }


        // EDIT

        public static void EditarSalario(int id, Salario novoSalario, Empregado novoEmpregado)
        {
            
            Salario salarioEditar = PesquisarPorID(id);

            if(salarioEditar != null)

            {

                // ver pesquisa cpf
                //salarioEditar._Empregado.Nome = novoSalario._Empregado.Nome;
                salarioEditar.QtdeHoraNormal = novoSalario.QtdeHoraNormal;
                salarioEditar.QtdeHoraExtra = novoSalario.QtdeHoraExtra;
                salarioEditar.VlrHoraNormal = novoSalario.VlrHoraNormal;
                salarioEditar.VlrHoraExtra = novoSalario.VlrHoraExtra;
                salarioEditar.VlrInss = novoSalario.VlrInss;
                salarioEditar.VlrIR = novoSalario.VlrIR;
                salarioEditar.SalarioBruto = novoSalario.SalarioBruto;
                salarioEditar.SalarioLiquido = novoSalario.SalarioLiquido;
                salarioEditar.Mes = novoSalario.Mes;
                salarioEditar.Ano = novoSalario.Ano;

                ContextoSingleton.Instancia.Entry(salarioEditar).State = System.Data.Entity.EntityState.Modified;

                ContextoSingleton.Instancia.SaveChanges();

            }
        }

        // DELETE

        public static void ExcluirSalario(int id)
        {
            
            Salario s = ContextoSingleton.Instancia.Salarios.Find(id);
            ContextoSingleton.Instancia.Entry(s).State = System.Data.Entity.EntityState.Deleted;

            ContextoSingleton.Instancia.SaveChanges();


        }




    }
}
