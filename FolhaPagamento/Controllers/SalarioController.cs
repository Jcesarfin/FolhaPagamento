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

        public Salario PesquisarPorCpfMesAno(string cpf)     /// consulta desejada (string cpf, int mes, int ano)
        {
            var s = from x in ContextoSingleton.Instancia.Salarios
                    where x._Empregado.CPF.Contains(cpf.Trim().ToLower())
                    select x;

            if (s != null)
               return s.FirstOrDefault();
            else
                return null;
        }


        // EDIT

        public static void EditarSalario(int id, Salario novoSalario)
        {
            
            Salario salarioEditar = PesquisarPorID(id);

            if(salarioEditar != null)

            {
                             
                salarioEditar.QtdeHoraNormal = novoSalario.QtdeHoraNormal;
                salarioEditar.QtdeHoraExtra = novoSalario.QtdeHoraExtra;
                salarioEditar.VlrHoraNormal = novoSalario.VlrHoraNormal;
                salarioEditar.VlrHoraExtra = novoSalario.VlrHoraExtra;
                salarioEditar.VlrInss = novoSalario.VlrInss;
                salarioEditar.VlrIR = novoSalario.VlrIR;
                salarioEditar.SalarioBruto = novoSalario.SalarioBruto;
                salarioEditar.SalarioLiquido = novoSalario.SalarioLiquido;
                

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
