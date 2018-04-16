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
            ContextoSingleton.Instancia.Departamentos.Add(departamento);
            ContextoSingleton.Instancia.SaveChanges();

        }

        // SELECT *

        public static List<Departamento> ListarDepartamentos()
        {
           return ContextoSingleton.Instancia.Departamentos.ToList();
        }

       

        

        // SELECT BY ID

        public static Departamento PesquisarPorID (int id)
        {
           return ContextoSingleton.Instancia.Departamentos.Find(id);
        }


        public Departamento PesquisarPorNome(string nome)
        {
            var c = from x in ContextoSingleton.Instancia.Departamentos
                    where x.NomeDepartamento.ToLower().Contains(nome.Trim().ToLower())
                    select x;

            if (c != null)
                return c.FirstOrDefault();
            else
                return null;
        }

        


        // EDIT

        public static void EditarDepartamento(int id, Departamento novoDepartamento)
        {
            
           Departamento departamentoEditar = PesquisarPorID(id);

            if (departamentoEditar != null)
            {
                departamentoEditar.NomeDepartamento = novoDepartamento.NomeDepartamento;
                departamentoEditar.LocalDepartamento = novoDepartamento.LocalDepartamento;

                ContextoSingleton.Instancia.Entry(departamentoEditar).State = System.Data.Entity.EntityState.Modified;

                ContextoSingleton.Instancia.SaveChanges();


            }
        }

        // DELETE

        public static void ExcluirDepartamento (int id)
        {
            Departamento d = ContextoSingleton.Instancia.Departamentos.Find(id);
            ContextoSingleton.Instancia.Entry(d).State = System.Data.Entity.EntityState.Deleted;

            ContextoSingleton.Instancia.SaveChanges();
            

        }
        
    }
}
