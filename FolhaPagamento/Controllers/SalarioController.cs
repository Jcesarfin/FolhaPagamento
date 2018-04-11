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
            MeuContexto bancoDados = new MeuContexto();

            bancoDados.Salarios.Add(salario);
            bancoDados.SaveChanges();
        }

        // SELECT *

        public static List<Salario> ListarSalarios()
        {
            MeuContexto bancoDados = new MeuContexto();
            return bancoDados.Salarios.ToList();
        }

        // SELECT BY ID

        public static Salario PesquisarPorID(int id)
        {
            MeuContexto bancoDados = new MeuContexto();
            return bancoDados.Salarios.Find(id);
        }

        // EDIT

        public static void EditarSalario(int id, Salario novoSalario)
        {
            MeuContexto bancoDados = new MeuContexto();
            Salario salarioAtual = bancoDados.Salarios.Find(id);

            // ver pesquisa cpf
            salarioAtual._Empregado.Nome = novoSalario._Empregado.Nome;
            salarioAtual.QtdeHoraNormal = novoSalario.QtdeHoraNormal;
            salarioAtual.QtdeHoraExtra = novoSalario.QtdeHoraExtra;
            salarioAtual.VlrHoraNormal = novoSalario.VlrHoraNormal;
            salarioAtual.VlrHoraExtra = novoSalario.VlrHoraExtra;
            salarioAtual.VlrInss = novoSalario.VlrInss;
            salarioAtual.VlrIR = novoSalario.VlrIR;
            salarioAtual.SalarioBruto = novoSalario.SalarioBruto;
            salarioAtual.SalarioLiquido = novoSalario.SalarioLiquido;
            salarioAtual.Mes = novoSalario.Mes;
            salarioAtual.Ano = novoSalario.Ano;

            bancoDados.Entry(salarioAtual).State = System.Data.Entity.EntityState.Modified;
            bancoDados.SaveChanges();

        }

        // DELETE

        public static void ExcluirSalario(int id)
        {
            MeuContexto bancoDados = new MeuContexto();
            Salario salarioAtual = bancoDados.Salarios.Find(id);

            bancoDados.Entry(salarioAtual).State = System.Data.Entity.EntityState.Deleted;
            bancoDados.SaveChanges();

        }

    }
}
