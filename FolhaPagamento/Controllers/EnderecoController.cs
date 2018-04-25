using Models;
using Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class EnderecoController
    {
        // INSERT

        public static void SalvarEndereco(Endereco endereco)
        {
           ContextoSingleton.Instancia.Enderecos.Add(endereco);
            ContextoSingleton.Instancia.SaveChanges();


        }

        // SELECT *

        public static List<Endereco> ListarEnderecos()
        {
            return ContextoSingleton.Instancia.Enderecos.ToList();
        }

        // SELECT BY ID

       public static Endereco PesquisarPorID(int id)
       {
           return ContextoSingleton.Instancia.Enderecos.Find(id);
        }


        public Endereco PesquisarPorRua(string rua)
        {
            var c = from x in ContextoSingleton.Instancia.Enderecos
                    where x.Rua.ToLower().Contains(rua.Trim().ToLower()) 
                  select x;

            if (c != null)
                return c.FirstOrDefault();
            else
                return null;
        }



        // EDIT -> NÃO UTILIZADO

        public static void EditarEndereco(int id, Endereco novoEndereco)
        {
            Endereco enderecoEditar = PesquisarPorID(id);

            if (enderecoEditar != null)

            {
                enderecoEditar.Rua = novoEndereco.Rua;
                enderecoEditar.Numero = novoEndereco.Numero;
                enderecoEditar.Cep = novoEndereco.Cep;
                enderecoEditar.Complemento = novoEndereco.Complemento;

                ContextoSingleton.Instancia.Entry(enderecoEditar).State = System.Data.Entity.EntityState.Modified;

                ContextoSingleton.Instancia.SaveChanges();

            }
        }

        // DELETE -> UTILIZADO

        public static void ExcluirEndereco(int EnderecoID)
        {
            Endereco e = ContextoSingleton.Instancia.Enderecos.Find(EnderecoID);
            ContextoSingleton.Instancia.Entry(e).State = System.Data.Entity.EntityState.Deleted;

            ContextoSingleton.Instancia.SaveChanges();
            
        }



    }
}
