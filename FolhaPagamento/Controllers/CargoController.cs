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
        // INSERT OK

        public static void SalvarCargo(Cargo cargo)
        {
            ContextoSingleton.Instancia.Cargos.Add(cargo);
            ContextoSingleton.Instancia.SaveChanges();
        }

        // SELECT * OK

        public static List<Cargo> ListarCargos()
        {
            return ContextoSingleton.Instancia.Cargos.ToList();

        }

        // SELECT BY ID  NÃO UTILIZADO

        //public Cargo PesquisarPorID(int id)    // tirei o static
        //{
                                 
          //  return ContextoSingleton.Instancia.Cargos.Find(id);
        //}


        //public Cargo PesquisarPorNome(string nome)
        //{
           // var c = from x in ContextoSingleton.Instancia.Cargos
           //         where x.NomeCargo.ToLower().Contains(nome.Trim().ToLower())
           //         select x;

          //  if (c != null)
        //        return c.FirstOrDefault();
        //    else
           //     return null;
       // }



        // EDIT NÃO UTILIZADO

       // public static void EditarCargo(int id, Cargo novoCargo)
       // {
       //     Cargo cargoEditar = PesquisarPorID(id);

        //    if (cargoEditar != null)

        //    {
        //        cargoEditar.NomeCargo = novoCargo.NomeCargo;
        //        cargoEditar.ValorHora = novoCargo.ValorHora;

                
        //        ContextoSingleton.Instancia.Entry(cargoEditar).State = System.Data.Entity.EntityState.Modified;

         //       ContextoSingleton.Instancia.SaveChanges();
          //  }

       // }

        // DELETE NÃO UTILIZADDO

       // public static void ExcluirCargo(int id)
      //  {
        //    Empregado e = ContextoSingleton.Instancia.Empregados.Find(id);
       //     ContextoSingleton.Instancia.Entry(e).State = System.Data.Entity.EntityState.Deleted;

       //     ContextoSingleton.Instancia.SaveChanges();



      //  }




    }
}
