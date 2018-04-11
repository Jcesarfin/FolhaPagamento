using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class CargoController
    {
        // INSERT

        public static void SalvarCargo(Cargo cargo)
        {
            MeuContexto bancoDados = new MeuContexto();

            bancoDados.Cargos.Add(cargo);
            bancoDados.SaveChanges();
        }

        // SELECT *

        public static List<Cargo> ListarCargos()
        {
            MeuContexto bancoDados = new MeuContexto();
            return bancoDados.Cargos.ToList();
        }

        // SELECT BY ID

        public static Cargo PesquisarPorID(int id)
        {
            MeuContexto bancoDados = new MeuContexto();
            return bancoDados.Cargos.Find(id);
        }

        // EDIT

        public static void EditarCargo(int id, Cargo novoCargo)
        {
            MeuContexto bancoDados = new MeuContexto();
            Cargo cargoAtual = bancoDados.Cargos.Find(id);

            cargoAtual.NomeCargo = novoCargo.NomeCargo;
            cargoAtual.ValorHora = novoCargo.ValorHora;

            bancoDados.Entry(cargoAtual).State = System.Data.Entity.EntityState.Modified;
            bancoDados.SaveChanges();

        }

        // DELETE

        public static void ExcluirCargo(int id)
        {
            MeuContexto bancoDados = new MeuContexto();
            Cargo cargoAtual = bancoDados.Cargos.Find(id);

            bancoDados.Entry(cargoAtual).State = System.Data.Entity.EntityState.Deleted;
            bancoDados.SaveChanges();

        }




    }
}
